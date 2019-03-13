namespace SokoManMap
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.meunFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetMap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetupWave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetupMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolResetMap = new System.Windows.Forms.ToolStripButton();
            this.toolGoBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPlay = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuControl,
            this.menuSetup,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.toolStripSeparator1,
            this.meunFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.menuFileOpen.Text = "打开(&O)      ...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // meunFileExit
            // 
            this.meunFileExit.Name = "meunFileExit";
            this.meunFileExit.Size = new System.Drawing.Size(152, 22);
            this.meunFileExit.Text = "退出(&X)";
            this.meunFileExit.Click += new System.EventHandler(this.meunFileExit_Click);
            // 
            // menuControl
            // 
            this.menuControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResetMap,
            this.menuGoBack,
            this.toolStripSeparator4,
            this.menuPrev,
            this.menuNext});
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(60, 21);
            this.menuControl.Text = "控制(&C)";
            // 
            // menuResetMap
            // 
            this.menuResetMap.Image = ((System.Drawing.Image)(resources.GetObject("menuResetMap.Image")));
            this.menuResetMap.Name = "menuResetMap";
            this.menuResetMap.Size = new System.Drawing.Size(142, 22);
            this.menuResetMap.Text = "复位(&R)";
            this.menuResetMap.Click += new System.EventHandler(this.menuResetMap_Click);
            // 
            // menuGoBack
            // 
            this.menuGoBack.Name = "menuGoBack";
            this.menuGoBack.Size = new System.Drawing.Size(142, 22);
            this.menuGoBack.Text = "后退(&B)";
            this.menuGoBack.Click += new System.EventHandler(this.menuGoBack_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(139, 6);
            // 
            // menuPrev
            // 
            this.menuPrev.Image = ((System.Drawing.Image)(resources.GetObject("menuPrev.Image")));
            this.menuPrev.Name = "menuPrev";
            this.menuPrev.Size = new System.Drawing.Size(142, 22);
            this.menuPrev.Text = "前一地图(&P)";
            this.menuPrev.Click += new System.EventHandler(this.menuPrev_Click);
            // 
            // menuNext
            // 
            this.menuNext.Image = ((System.Drawing.Image)(resources.GetObject("menuNext.Image")));
            this.menuNext.Name = "menuNext";
            this.menuNext.Size = new System.Drawing.Size(142, 22);
            this.menuNext.Text = "后一地图(&N)";
            this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // menuSetup
            // 
            this.menuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetupWave,
            this.menuSetupMusic});
            this.menuSetup.Name = "menuSetup";
            this.menuSetup.Size = new System.Drawing.Size(59, 21);
            this.menuSetup.Text = "设置(&S)";
            // 
            // menuSetupWave
            // 
            this.menuSetupWave.Image = ((System.Drawing.Image)(resources.GetObject("menuSetupWave.Image")));
            this.menuSetupWave.Name = "menuSetupWave";
            this.menuSetupWave.Size = new System.Drawing.Size(120, 22);
            this.menuSetupWave.Text = "声效(&W)";
            this.menuSetupWave.Click += new System.EventHandler(this.meunSetupWave_Click);
            // 
            // menuSetupMusic
            // 
            this.menuSetupMusic.Checked = true;
            this.menuSetupMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSetupMusic.Image = ((System.Drawing.Image)(resources.GetObject("menuSetupMusic.Image")));
            this.menuSetupMusic.Name = "menuSetupMusic";
            this.menuSetupMusic.Size = new System.Drawing.Size(120, 22);
            this.menuSetupMusic.Text = "音乐(&M)";
            this.menuSetupMusic.Click += new System.EventHandler(this.menuSetupMusic_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpTopic,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuHelpTopic
            // 
            this.menuHelpTopic.Image = ((System.Drawing.Image)(resources.GetObject("menuHelpTopic.Image")));
            this.menuHelpTopic.Name = "menuHelpTopic";
            this.menuHelpTopic.Size = new System.Drawing.Size(139, 22);
            this.menuHelpTopic.Text = "帮助主题(&T)";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(139, 22);
            this.menuAbout.Text = "关于(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolResetMap,
            this.toolGoBack,
            this.toolStripSeparator2,
            this.toolPrev,
            this.toolNext,
            this.toolStripSeparator3,
            this.toolHelp,
            this.toolPlay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolResetMap
            // 
            this.toolResetMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolResetMap.Image = ((System.Drawing.Image)(resources.GetObject("toolResetMap.Image")));
            this.toolResetMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolResetMap.Name = "toolResetMap";
            this.toolResetMap.Size = new System.Drawing.Size(23, 22);
            this.toolResetMap.Text = "复位（ESC）";
            this.toolResetMap.Click += new System.EventHandler(this.toolResetMap_Click);
            // 
            // toolGoBack
            // 
            this.toolGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGoBack.Enabled = false;
            this.toolGoBack.Image = ((System.Drawing.Image)(resources.GetObject("toolGoBack.Image")));
            this.toolGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGoBack.Name = "toolGoBack";
            this.toolGoBack.Size = new System.Drawing.Size(23, 22);
            this.toolGoBack.Text = "后退（Space）";
            this.toolGoBack.Click += new System.EventHandler(this.toolGoBack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolPrev
            // 
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolPrev.Image")));
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(23, 22);
            this.toolPrev.Text = "前一地图";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolNext
            // 
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.Image = ((System.Drawing.Image)(resources.GetObject("toolNext.Image")));
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(23, 22);
            this.toolNext.Text = "后一地图";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolHelp
            // 
            this.toolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolHelp.Image")));
            this.toolHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(23, 22);
            this.toolHelp.Text = "帮助";
            this.toolHelp.Visible = false;
            this.toolHelp.Click += new System.EventHandler(this.toolHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(202, 17);
            this.toolStripStatusLabel1.Text = "By:GaoHai(Seabluescn@163.com)";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.BackColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(440, 17);
            this.statusLabel.Text = "Ready!";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolPlay
            // 
            this.toolPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolPlay.Image")));
            this.toolPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPlay.Name = "toolPlay";
            this.toolPlay.Size = new System.Drawing.Size(52, 22);
            this.toolPlay.Text = "回放";
            this.toolPlay.Click += new System.EventHandler(this.toolPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(732, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Soko";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meunFileExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolResetMap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolGoBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolHelp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuControl;
        private System.Windows.Forms.ToolStripMenuItem menuResetMap;
        private System.Windows.Forms.ToolStripMenuItem menuGoBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuPrev;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuSetup;
        private System.Windows.Forms.ToolStripMenuItem menuSetupWave;
        private System.Windows.Forms.ToolStripMenuItem menuSetupMusic;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpTopic;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton toolPlay;
    }
}

