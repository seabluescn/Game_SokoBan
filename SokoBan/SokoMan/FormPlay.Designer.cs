namespace SokoManMap
{
    partial class FormPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolMakeGIF = new System.Windows.Forms.ToolStripButton();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolReset,
            this.toolBack,
            this.toolPrev,
            this.toolMakeGIF});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBack
            // 
            this.toolBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBack.Image = ((System.Drawing.Image)(resources.GetObject("toolBack.Image")));
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(36, 22);
            this.toolBack.Text = "向后";
            this.toolBack.Click += new System.EventHandler(this.toolBack_Click);
            // 
            // toolPrev
            // 
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolPrev.Image")));
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(36, 22);
            this.toolPrev.Text = "向前";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolMakeGIF
            // 
            this.toolMakeGIF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolMakeGIF.Image = ((System.Drawing.Image)(resources.GetObject("toolMakeGIF.Image")));
            this.toolMakeGIF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMakeGIF.Name = "toolMakeGIF";
            this.toolMakeGIF.Size = new System.Drawing.Size(55, 22);
            this.toolMakeGIF.Text = "制作GIF";
            this.toolMakeGIF.Click += new System.EventHandler(this.toolMakeGIF_Click);
            // 
            // toolReset
            // 
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolReset.Image = ((System.Drawing.Image)(resources.GetObject("toolReset.Image")));
            this.toolReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReset.Name = "toolReset";
            this.toolReset.Size = new System.Drawing.Size(36, 22);
            this.toolReset.Text = "复位";
            this.toolReset.Click += new System.EventHandler(this.toolReset_Click);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 399);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolMakeGIF;
        private System.Windows.Forms.ToolStripButton toolReset;
    }
}