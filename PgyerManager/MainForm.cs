using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PgyerManager
{
    public partial class MainForm : Form
    {

        private string downloadUrl = "";
        private const string UPLOAD_URL = "http://www.pgyer.com/apiv2/app/upload";
        private delegate void InvokeCallback(string msg);

        private int defaultConfig = -1;
        private List<CustomConfig> confList;
        private CustomConfig currentConfig;

        public MainForm(string[] args)
        {
            InitializeComponent();
            uploadWorker.DoWork += UploadWorker_DoWork;
            uploadWorker.ProgressChanged += UploadWorker_ProgressChanged;
            uploadWorker.RunWorkerCompleted += UploadWorker_RunWorkerCompleted;
            defaultConfig = Properties.Settings.Default.defaultConfig;
            string savedConfig = Properties.Settings.Default.config;
            if (savedConfig != null && savedConfig != "")
            {
                confList = FromJSON<List<CustomConfig>>(savedConfig);
            }
            else
            {
                confList = new List<CustomConfig>();
            }

            CheckArgs(args);
            CheckEnvPath();
        }

        private void CheckArgs(string[] args)
        {
            if (args != null)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-cmd"||args[i] == "-c")
                    {
                        i += 1;
                        if (i < args.Length)
                        {
                            for (int j = 0; j < confList.Count; j++)
                            {
                                if (confList[j].Cmd == args[i])
                                {
                                    currentConfig = confList[j];
                                    
                                }
                            }
                        }

                    }
                        
                }
                
            }
        }

        
        private void CheckEnvPath()
        {
            string allPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            string[] paths = allPath.Split(';');
            StringBuilder sb = new StringBuilder();
            bool contains = false;
            for (int i = 0; i < paths.Length; i++)
            {
                if (paths[i] == Application.StartupPath)
                {
                    contains = true;
                }
                else
                {
                    sb.Append(paths[i]).Append(";");
                }
            }

            if (!contains)
            {
                sb.Append(";").Append(Application.StartupPath);
                Environment.SetEnvironmentVariable("PATH", sb.ToString(), EnvironmentVariableTarget.User);
            }          
        }

        private void UploadWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnUpload.Enabled = true;
            tbFile.Enabled = true;
            if (e.Cancelled)
            {
                this.Close();
            }

            if (e.Error != null)
            {
                Type errorType = e.Error.GetType();
                switch (errorType.Name)
                {
                    case "ArgumentNullException":
                    case "MyException":
                        //do something.
                        break;
                    default:
                        //do something.
                        break;
                }
            }
            else
            {
                UpdateUI((string)e.Result);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbCode.Image = PgyerManager.Properties.Resources.ic_loading;
            pbIcon.Image = PgyerManager.Properties.Resources.ic_loading;
            uploadWorker.RunWorkerAsync();
            btnUpload.Enabled = false;
            tbFile.Enabled = false;
        }


        private void UploadWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.tbConsole.Text = e.UserState.ToString();
            sProgressBar.Value = e.ProgressPercentage;
            sLabel.Text = e.UserState.ToString();
        }

        private void UploadWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            NameValueCollection para = new NameValueCollection();
            para.Add("_api_key", currentConfig.ApiKey);
            string response = UploadFilesToRemoteUrl(UPLOAD_URL, new String[] { tbFile.Text }, para);
            e.Result = response;
        }



        private void UpdateUI(string json)
        {
            JObject obj = (JObject)JsonConvert.DeserializeObject(json);
            JObject data = (JObject)obj["data"];
            UploadResult result = FromJSON<UploadResult>(data.ToString());
            result.JsonResult = json;
            tbConsole.Text = result.JsonResult;
            pbCode.Image = Image.FromStream(WebRequest.Create(result.BuildQRCodeURL).GetResponse().GetResponseStream());
            pbIcon.Image = Image.FromStream(WebRequest.Create(String.Format("https://appicon.pgyer.com/image/view/app_icons/{0}/", result.BuildIcon)).GetResponse().GetResponseStream());
            StringBuilder sb = new StringBuilder();
            sb.Append("应用名 " + result.BuildName).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("包名 " + result.BuildIdentifier).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("版本 " + result.BuildVersion).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("版本号 " + result.BuildVersionNo).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("更新次数 " + result.BuildBuildVersion).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("文件名 " + result.BuildFileName).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("文件大小 " + result.BuildFileSize).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("安装类型 " + result.BuildType).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("创建时间 " + result.BuildCreated).Append(Environment.NewLine).Append(Environment.NewLine);
            sb.Append("更新时间 " + result.BuildUpdated).Append(Environment.NewLine).Append(Environment.NewLine);
            downloadUrl = "http://www.pgyer.com/" + result.BuildShortcutUrl;
            sb.Append("下载地址 ").Append(downloadUrl).Append(Environment.NewLine);
            sb.Append("描述 " + result.BuildDescription).Append(Environment.NewLine).Append(Environment.NewLine);
            tbInfo.Text = sb.ToString();
            tbConsole.Text = downloadUrl+" "+confList[defaultConfig].MessgeTemplate;
            Clipboard.SetText(tbConsole.Text);
            tbConsole.AppendText(Environment.NewLine + "[已复制到剪切板]");
        }

        private T FromJSON<T>(string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception ex)
            {

                return default(T);
            }
        }


        public string UploadFilesToRemoteUrl(string url, string[] files, NameValueCollection formFields)
        {
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "multipart/form-data; boundary=" +
                                    boundary;
            request.Method = "POST";
            request.KeepAlive = true;
            request.Timeout = 3000000;
            Stream memStream = new System.IO.MemoryStream();

            var boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" +
                                                                    boundary + "\r\n");
            var endBoundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" +
                                                                        boundary + "--");


            string formdataTemplate = "\r\n--" + boundary +
                                        "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";

            if (formFields != null)
            {
                foreach (string key in formFields.Keys)
                {
                    string formitem = string.Format(formdataTemplate, key, formFields[key]);
                    byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                    memStream.Write(formitembytes, 0, formitembytes.Length);
                }
            }

            string headerTemplate =
                "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
                "Content-Type: application/octet-stream\r\n\r\n";

            for (int i = 0; i < files.Length; i++)
            {
                memStream.Write(boundarybytes, 0, boundarybytes.Length);
                var header = string.Format(headerTemplate, "file", files[i]);
                var headerbytes = System.Text.Encoding.UTF8.GetBytes(header);

                memStream.Write(headerbytes, 0, headerbytes.Length);

                using (var fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                {
                    var buffer = new byte[1024];
                    var bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        memStream.Write(buffer, 0, bytesRead);
                    }
                }
            }

            memStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            request.ContentLength = memStream.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                int bufferLength = 4 * 1024;
                byte[] bufferBytes = new byte[bufferLength];
                memStream.Position = 0;
                int size = memStream.Read(bufferBytes, 0, bufferLength);
                long offset = 0;
                long toltalLength = memStream.Length;
                while (size > 0)
                {
                    requestStream.Write(bufferBytes, 0, size);
                    offset += size;
                    uploadWorker.ReportProgress((int)(offset * 100 / toltalLength), String.Format("已上传 {0:F2}M/ {1:F2}M", offset / 1048576.0, toltalLength / 1048576.0));
                    size = memStream.Read(bufferBytes, 0, bufferLength);
                }
            }

            using (var response = request.GetResponse())
            {
                Stream stream2 = response.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
                return reader2.ReadToEnd();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbKey.Text = Properties.Settings.Default.apiKey;
            tbFile.Focus();
            UpdateListView();
            if (currentConfig != null)
            {
                tbFile.Text = currentConfig.Path;
                btnUpload.PerformClick();
            }
            
        }

        private void UpdateListView()
        {
            lvConfig.Items.Clear();
            lvConfig.BeginUpdate();
            comboConfig.Items.Clear();
            foreach (var c in confList)
            {
                AddListItem(c);
                comboConfig.Items.Add(c.Name);
            }
            lvConfig.EndUpdate();
            if (defaultConfig != -1)
            {
                lvConfig.Items[defaultConfig].BackColor = Color.FromArgb(41, 206, 173);
                lvConfig.Items[defaultConfig].ForeColor = Color.White;
                tbFile.Text = confList[defaultConfig].Path;
            }
            for (int i = 0; i < 5; i++)
            {
                lvConfig.Columns[i].Width = -1; //每一列自适应宽度
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.apiKey = tbKey.Text;
            Properties.Settings.Default.defaultConfig = defaultConfig;
            Properties.Settings.Default.config = JsonConvert.SerializeObject(confList);
            Properties.Settings.Default.Save();
        }

        private void tUrl_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpenFileMain_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "所有包(*.ipa;*.apk)|*.ipa;*.apk|Android包(*.apk)|*.apk|iOS包(*.ipa)|*.ipa";
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
               tbFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnConfigAdd_Click(object sender, EventArgs e)
        {           
            AddConfigForm form = new AddConfigForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                CustomConfig r = form.Config;
                confList.Add(r);
                AddListItem(r);
            }
        }

        private void AddListItem(CustomConfig config)
        {
            ListViewItem item = new ListViewItem(new[] { config.Name, config.MessgeTemplate, config.Cmd, config.Path, config.ApiKey});
            if ((lvConfig.Items.Count + 1) % 2 == 0)
            {
                item.BackColor = Color.WhiteSmoke;
            }
            else
            {
                item.BackColor = Color.White; ;
            }
            lvConfig.Items.Add(item);
        }

        private void lvConfig_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (ListViewItem lv in lvConfig.Items)
            {
                if (lv.Selected)
                {
                    lv.Checked = true;

                }
                else
                {
                    if (lvConfig.SelectedIndices.Count > 0)
                    {
                        if (lv.Checked)
                        {
                            lv.Checked = false;
                        }
                    }

                }
            }
        }

        private void btnConfigDefault_Click(object sender, EventArgs e)
        {
            if (lvConfig.SelectedIndices.Count > 0)
            {
            
                defaultConfig = lvConfig.SelectedIndices[0];
                MessageBox.Show(defaultConfig+"");
                UpdateListView();
            }
        }

        private void tUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (downloadUrl != null && downloadUrl != "")
            {
                System.Diagnostics.Process.Start(downloadUrl);
            }
        }

        private void btnConfigDelete_Click(object sender, EventArgs e)
        {
            if (lvConfig.SelectedIndices.Count > 0)
            {
                defaultConfig = lvConfig.SelectedIndices[0];
                confList.RemoveAt(defaultConfig);
                UpdateListView();
            }
        }

        private void lvConfig_DoubleClick(object sender, EventArgs e)
        {
            btnConfigEdit.PerformClick();
        }

        private void btnConfigEdit_Click(object sender, EventArgs e)
        {
            if (lvConfig.SelectedIndices.Count > 0)
            {
                int idx = lvConfig.SelectedIndices[0];
                AddConfigForm form = new AddConfigForm(confList[idx]);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    confList[idx] = form.Config;
                    UpdateListView();

                }
            }
            else
            {
                MessageBox.Show("您还没有选择一个配置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void comboConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
