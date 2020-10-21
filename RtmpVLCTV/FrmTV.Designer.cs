namespace RtmpVLCTV
{
    partial class FrmTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTV));
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.menuStripChannel = new System.Windows.Forms.MenuStrip();
            this.menuSelectChannel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.menuStripChannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(0, 25);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(800, 425);
            this.videoView1.TabIndex = 0;
            this.videoView1.Text = "videoView1";
            // 
            // menuStripChannel
            // 
            this.menuStripChannel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectChannel});
            this.menuStripChannel.Location = new System.Drawing.Point(0, 0);
            this.menuStripChannel.Name = "menuStripChannel";
            this.menuStripChannel.Size = new System.Drawing.Size(800, 25);
            this.menuStripChannel.TabIndex = 1;
            this.menuStripChannel.Text = "menuStrip1";
            // 
            // menuSelectChannel
            // 
            this.menuSelectChannel.Name = "menuSelectChannel";
            this.menuSelectChannel.Size = new System.Drawing.Size(44, 21);
            this.menuSelectChannel.Text = "选台";
            this.menuSelectChannel.Click += new System.EventHandler(this.menuSelectChannel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.menuStripChannel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripChannel;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "湖南卫视";
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.menuStripChannel.ResumeLayout(false);
            this.menuStripChannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.MenuStrip menuStripChannel;
        private System.Windows.Forms.ToolStripMenuItem menuSelectChannel;
    }
}

