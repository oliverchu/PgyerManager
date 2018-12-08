using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PgyerManager
{
    public partial class AddConfigForm : Form
    {
        private CustomConfig config;

        internal CustomConfig Config { get => config; set => config = value; }

        public AddConfigForm()
        {
            InitializeComponent();
            config = new CustomConfig();
        }

        public AddConfigForm(CustomConfig config)
        {
            InitializeComponent();
            if (config != null)
            {
                this.config = config;
                SetValues();
            }
            else
            {
                this.config = new CustomConfig();
            }
        }

        private void SetValues()
        {
            tbName.Text = config.Name;
            tbPath.Text = config.Path;
            tbApiKey.Text = config.ApiKey;
            tbCmd.Text = config.Cmd;
            tbMessageTemplate.Text = config.MessgeTemplate;
        }


        private void lOpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "所有包(*.ipa;*.apk)|*.ipa;*.apk|Android包(*.apk)|*.apk|iOS包(*.ipa)|*.ipa";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Config.Name = tbName.Text.Trim();
            Config.Path = tbPath.Text.Trim();
            Config.ApiKey = tbApiKey.Text.Trim();
            Config.MessgeTemplate = tbMessageTemplate.Text.Trim();
            Config.Cmd = tbCmd.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }



        private void tbName_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
        private void CheckEmpty()
        {
            if (tbName.Text.Trim().Length == 0)
            {
                mErrorProvider.SetError(tbName, "名称不能为空");
                btnAdd.Enabled = false;
                return;
            }
            else if(tbName.Text.Trim().Length != 0)
            {
                mErrorProvider.SetError(tbName, null);
            }
            if (tbPath.Text.Trim().Length == 0)
            {
                mErrorProvider.SetError(tbPath, "路径不能为空");
                btnAdd.Enabled = false;
                return;
            }
            else if (tbPath.Text.Trim().Length != 0)
            {
                mErrorProvider.SetError(tbPath, null);
                btnAdd.Enabled = true;
            }
            

        }

        private void btnOutputHelp_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("您可以在文本加入如下通配符，用于替换文本：").AppendLine().AppendLine();
            sb.Append("下载链接 - ").Append("%l").AppendLine().AppendLine();
            sb.Append("时间 - ").Append("%t").AppendLine().AppendLine();
            sb.Append("平台 - ").Append("%p").AppendLine().AppendLine();
            sb.Append("名称 - ").Append("%n").AppendLine().AppendLine();
            MessageBox.Show(sb.ToString(), "帮助 - 通配符", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
