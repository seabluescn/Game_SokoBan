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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.meunFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolGlass = new System.Windows.Forms.ToolStripButton();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.toolRoad = new System.Windows.Forms.ToolStripButton();
            this.toolDirect = new System.Windows.Forms.ToolStripButton();
            this.toolBox = new System.Windows.Forms.ToolStripButton();
            this.toolDirectBox = new System.Windows.Forms.ToolStripButton();
            this.toolMan = new System.Windows.Forms.ToolStripButton();
            this.toolDirectMan = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.toolStripSeparator1,
            this.meunFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(108, 22);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(108, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(108, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // meunFileExit
            // 
            this.meunFileExit.Name = "meunFileExit";
            this.meunFileExit.Size = new System.Drawing.Size(108, 22);
            this.meunFileExit.Text = "Exit";
            this.meunFileExit.Click += new System.EventHandler(this.meunFileExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGlass,
            this.toolWall,
            this.toolRoad,
            this.toolDirect,
            this.toolBox,
            this.toolDirectBox,
            this.toolMan,
            this.toolDirectMan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolGlass
            // 
            this.toolGlass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGlass.Image = global::SokoManMap.Properties.Resources.None;
            this.toolGlass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGlass.Name = "toolGlass";
            this.toolGlass.Size = new System.Drawing.Size(23, 22);
            this.toolGlass.Text = "toolStripButton1";
            this.toolGlass.Click += new System.EventHandler(this.toolGlass_Click);
            // 
            // toolWall
            // 
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.Image = global::SokoManMap.Properties.Resources.Wall;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(23, 22);
            this.toolWall.Text = "toolStripButton2";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // toolRoad
            // 
            this.toolRoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRoad.Image = global::SokoManMap.Properties.Resources.Road;
            this.toolRoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoad.Name = "toolRoad";
            this.toolRoad.Size = new System.Drawing.Size(23, 22);
            this.toolRoad.Text = "toolStripButton3";
            this.toolRoad.Click += new System.EventHandler(this.toolRoad_Click);
            // 
            // toolDirect
            // 
            this.toolDirect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDirect.Image = global::SokoManMap.Properties.Resources.Direct;
            this.toolDirect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDirect.Name = "toolDirect";
            this.toolDirect.Size = new System.Drawing.Size(23, 22);
            this.toolDirect.Text = "toolStripButton4";
            this.toolDirect.Click += new System.EventHandler(this.toolDirect_Click);
            // 
            // toolBox
            // 
            this.toolBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBox.Image = global::SokoManMap.Properties.Resources.Box;
            this.toolBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(23, 22);
            this.toolBox.Text = "toolStripButton5";
            this.toolBox.Click += new System.EventHandler(this.toolBox_Click);
            // 
            // toolDirectBox
            // 
            this.toolDirectBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDirectBox.Image = global::SokoManMap.Properties.Resources.BoxInDirect;
            this.toolDirectBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDirectBox.Name = "toolDirectBox";
            this.toolDirectBox.Size = new System.Drawing.Size(23, 22);
            this.toolDirectBox.Text = "toolStripButton6";
            this.toolDirectBox.Click += new System.EventHandler(this.toolDirectBox_Click);
            // 
            // toolMan
            // 
            this.toolMan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMan.Image = global::SokoManMap.Properties.Resources.Man;
            this.toolMan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMan.Name = "toolMan";
            this.toolMan.Size = new System.Drawing.Size(23, 22);
            this.toolMan.Text = "toolStripButton7";
            this.toolMan.Click += new System.EventHandler(this.toolMan_Click);
            // 
            // toolDirectMan
            // 
            this.toolDirectMan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDirectMan.Image = global::SokoManMap.Properties.Resources.ManInDirect;
            this.toolDirectMan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDirectMan.Name = "toolDirectMan";
            this.toolDirectMan.Size = new System.Drawing.Size(23, 22);
            this.toolDirectMan.Text = "toolStripButton8";
            this.toolDirectMan.Click += new System.EventHandler(this.toolDirectMan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(202, 17);
            this.toolStripStatusLabel1.Text = "By GaoHai(seabluescn@163.com)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(635, 381);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "MapEdit";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
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
        private System.Windows.Forms.ToolStripButton toolGlass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolRoad;
        private System.Windows.Forms.ToolStripButton toolDirect;
        private System.Windows.Forms.ToolStripButton toolBox;
        private System.Windows.Forms.ToolStripButton toolDirectBox;
        private System.Windows.Forms.ToolStripButton toolMan;
        private System.Windows.Forms.ToolStripButton toolDirectMan;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

