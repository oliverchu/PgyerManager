namespace PgyerManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOpenFileMain = new System.Windows.Forms.Button();
            this.lFileName = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tUrl = new System.Windows.Forms.LinkLabel();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.uploadWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.sLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConfigAdd = new System.Windows.Forms.Button();
            this.lvConfig = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfigDefault = new System.Windows.Forms.Button();
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnConfigDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(206)))), ((int)(((byte)(173)))));
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpload.Location = new System.Drawing.Point(537, 31);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 71);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.BackColor = System.Drawing.SystemColors.Control;
            this.tbConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConsole.Location = new System.Drawing.Point(6, 437);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(501, 86);
            this.tbConsole.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 555);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnOpenFileMain);
            this.tabPage1.Controls.Add(this.tbConsole);
            this.tabPage1.Controls.Add(this.lFileName);
            this.tabPage1.Controls.Add(this.tbFile);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上传";
            // 
            // btnOpenFileMain
            // 
            this.btnOpenFileMain.Location = new System.Drawing.Point(432, 31);
            this.btnOpenFileMain.Name = "btnOpenFileMain";
            this.btnOpenFileMain.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileMain.TabIndex = 19;
            this.btnOpenFileMain.Text = "打开";
            this.btnOpenFileMain.UseVisualStyleBackColor = true;
            this.btnOpenFileMain.Click += new System.EventHandler(this.btnOpenFileMain_Click);
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lFileName.Location = new System.Drawing.Point(12, 11);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(53, 12);
            this.lFileName.TabIndex = 18;
            this.lFileName.Text = "文件路径";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(14, 31);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(412, 21);
            this.tbFile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tUrl);
            this.groupBox1.Controls.Add(this.tbInfo);
            this.groupBox1.Controls.Add(this.pbCode);
            this.groupBox1.Controls.Add(this.pbIcon);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 373);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "应用信息";
            // 
            // tUrl
            // 
            this.tUrl.AutoSize = true;
            this.tUrl.Location = new System.Drawing.Point(39, 148);
            this.tUrl.Name = "tUrl";
            this.tUrl.Size = new System.Drawing.Size(53, 12);
            this.tUrl.TabIndex = 28;
            this.tUrl.TabStop = true;
            this.tUrl.Text = "打开链接";
            this.tUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tUrl_LinkClicked);
            // 
            // tbInfo
            // 
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbInfo.Location = new System.Drawing.Point(178, 20);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(317, 335);
            this.tbInfo.TabIndex = 27;
            this.tbInfo.Text = "无应用信息";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbKey);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfigDelete);
            this.groupBox2.Controls.Add(this.btnConfigDefault);
            this.groupBox2.Controls.Add(this.lvConfig);
            this.groupBox2.Controls.Add(this.btnConfigAdd);
            this.groupBox2.Location = new System.Drawing.Point(20, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 378);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义配置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "API KEY";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(69, 14);
            this.tbKey.Name = "tbKey";
            this.tbKey.PasswordChar = '*';
            this.tbKey.Size = new System.Drawing.Size(345, 21);
            this.tbKey.TabIndex = 0;
            // 
            // uploadWorker
            // 
            this.uploadWorker.WorkerReportsProgress = true;
            this.uploadWorker.WorkerSupportsCancellation = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sProgressBar,
            this.sLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sProgressBar
            // 
            this.sProgressBar.Name = "sProgressBar";
            this.sProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // sLabel
            // 
            this.sLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(44, 17);
            this.sLabel.Text = "无任务";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConfigAdd
            // 
            this.btnConfigAdd.Location = new System.Drawing.Point(7, 319);
            this.btnConfigAdd.Name = "btnConfigAdd";
            this.btnConfigAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfigAdd.TabIndex = 1;
            this.btnConfigAdd.Text = "添加";
            this.btnConfigAdd.UseVisualStyleBackColor = true;
            this.btnConfigAdd.Click += new System.EventHandler(this.btnConfigAdd_Click);
            // 
            // lvConfig
            // 
            this.lvConfig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvConfig.FullRowSelect = true;
            this.lvConfig.Location = new System.Drawing.Point(7, 20);
            this.lvConfig.Name = "lvConfig";
            this.lvConfig.ShowItemToolTips = true;
            this.lvConfig.Size = new System.Drawing.Size(589, 293);
            this.lvConfig.TabIndex = 2;
            this.lvConfig.UseCompatibleStateImageBehavior = false;
            this.lvConfig.View = System.Windows.Forms.View.Details;
            this.lvConfig.SelectedIndexChanged += new System.EventHandler(this.lvConfig_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "密匙";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "输出模板";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "自定义命令";
            this.columnHeader6.Width = 112;
            // 
            // btnConfigDefault
            // 
            this.btnConfigDefault.Location = new System.Drawing.Point(88, 319);
            this.btnConfigDefault.Name = "btnConfigDefault";
            this.btnConfigDefault.Size = new System.Drawing.Size(75, 23);
            this.btnConfigDefault.TabIndex = 3;
            this.btnConfigDefault.Text = "设置默认";
            this.btnConfigDefault.UseVisualStyleBackColor = true;
            this.btnConfigDefault.Click += new System.EventHandler(this.btnConfigDefault_Click);
            // 
            // pbCode
            // 
            this.pbCode.BackColor = System.Drawing.SystemColors.Control;
            this.pbCode.Location = new System.Drawing.Point(8, 184);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(144, 144);
            this.pbCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCode.TabIndex = 2;
            this.pbCode.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::PgyerManager.Properties.Resources.ic_android;
            this.pbIcon.Location = new System.Drawing.Point(8, 20);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(116, 114);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // btnConfigDelete
            // 
            this.btnConfigDelete.BackColor = System.Drawing.Color.Red;
            this.btnConfigDelete.Location = new System.Drawing.Point(521, 319);
            this.btnConfigDelete.Name = "btnConfigDelete";
            this.btnConfigDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConfigDelete.TabIndex = 4;
            this.btnConfigDelete.Text = "删除";
            this.btnConfigDelete.UseVisualStyleBackColor = false;
            this.btnConfigDelete.Click += new System.EventHandler(this.btnConfigDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 593);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蒲公英上传器 v1.0 by Oliver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.ComponentModel.BackgroundWorker uploadWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar sProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel sLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.LinkLabel tUrl;
        private System.Windows.Forms.Button btnOpenFileMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfigAdd;
        private System.Windows.Forms.ListView lvConfig;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnConfigDefault;
        private System.Windows.Forms.Button btnConfigDelete;
    }
}

