namespace S_net_Viewer
{
    partial class Display
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SnetImg = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.RC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RC_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_SaveSize = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Sites = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_UmisiruMap = new System.Windows.Forms.ToolStripMenuItem();
            this.RCbar = new System.Windows.Forms.ToolStripSeparator();
            this.RC_Twitter = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_GitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_reboot = new System.Windows.Forms.ToolStripMenuItem();
            this.SnetImgColor = new System.Windows.Forms.PictureBox();
            this.ImgChange = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SnetImg)).BeginInit();
            this.RC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnetImgColor)).BeginInit();
            this.SuspendLayout();
            // 
            // SnetImg
            // 
            this.SnetImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.SnetImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SnetImg.Location = new System.Drawing.Point(0, 0);
            this.SnetImg.Name = "SnetImg";
            this.SnetImg.Size = new System.Drawing.Size(200, 400);
            this.SnetImg.TabIndex = 0;
            this.SnetImg.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(0, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(127, 24);
            this.Time.TabIndex = 1;
            this.Time.Text = "---- / -- / --  -- : -- \r\n取得遅延 - - s";
            // 
            // RC
            // 
            this.RC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_setting,
            this.RC_SaveSize,
            this.RC_Sites,
            this.RC_reboot});
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(189, 92);
            // 
            // RC_setting
            // 
            this.RC_setting.Name = "RC_setting";
            this.RC_setting.Size = new System.Drawing.Size(188, 22);
            this.RC_setting.Text = "設定";
            this.RC_setting.Click += new System.EventHandler(this.RC_setting_Click);
            // 
            // RC_SaveSize
            // 
            this.RC_SaveSize.Name = "RC_SaveSize";
            this.RC_SaveSize.Size = new System.Drawing.Size(188, 22);
            this.RC_SaveSize.Text = "現在のサイズを設定する";
            this.RC_SaveSize.Click += new System.EventHandler(this.RC_SaveSize_Click);
            // 
            // RC_Sites
            // 
            this.RC_Sites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_UmisiruMap,
            this.RCbar,
            this.RC_Twitter,
            this.RC_GitHub});
            this.RC_Sites.Name = "RC_Sites";
            this.RC_Sites.Size = new System.Drawing.Size(188, 22);
            this.RC_Sites.Text = "各種サイト";
            // 
            // RC_UmisiruMap
            // 
            this.RC_UmisiruMap.Name = "RC_UmisiruMap";
            this.RC_UmisiruMap.Size = new System.Drawing.Size(157, 22);
            this.RC_UmisiruMap.Text = "海しるマップ";
            this.RC_UmisiruMap.Click += new System.EventHandler(this.RC_UmisiruMap_Click);
            // 
            // RCbar
            // 
            this.RCbar.Name = "RCbar";
            this.RCbar.Size = new System.Drawing.Size(154, 6);
            // 
            // RC_Twitter
            // 
            this.RC_Twitter.Name = "RC_Twitter";
            this.RC_Twitter.Size = new System.Drawing.Size(157, 22);
            this.RC_Twitter.Text = "製作者Twitter";
            this.RC_Twitter.Click += new System.EventHandler(this.RC_Twitter_Click);
            // 
            // RC_GitHub
            // 
            this.RC_GitHub.Name = "RC_GitHub";
            this.RC_GitHub.Size = new System.Drawing.Size(157, 22);
            this.RC_GitHub.Text = "GitHubレポジトリ";
            this.RC_GitHub.Click += new System.EventHandler(this.RC_GitHub_Click);
            // 
            // RC_reboot
            // 
            this.RC_reboot.Name = "RC_reboot";
            this.RC_reboot.Size = new System.Drawing.Size(188, 22);
            this.RC_reboot.Text = "再起動";
            this.RC_reboot.Click += new System.EventHandler(this.RC_reboot_Click);
            // 
            // SnetImgColor
            // 
            this.SnetImgColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.SnetImgColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SnetImgColor.Location = new System.Drawing.Point(0, 0);
            this.SnetImgColor.Name = "SnetImgColor";
            this.SnetImgColor.Size = new System.Drawing.Size(0, 0);
            this.SnetImgColor.TabIndex = 2;
            this.SnetImgColor.TabStop = false;
            // 
            // ImgChange
            // 
            this.ImgChange.Enabled = true;
            this.ImgChange.Interval = 10000;
            this.ImgChange.Tick += new System.EventHandler(this.ImgChange_Tick);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(200, 400);
            this.ContextMenuStrip = this.RC;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.SnetImgColor);
            this.Controls.Add(this.SnetImg);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "Display";
            this.Text = "S-net Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_FormClosing);
            this.Load += new System.EventHandler(this.Display_Load);
            this.Resize += new System.EventHandler(this.Display_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SnetImg)).EndInit();
            this.RC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SnetImgColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SnetImg;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ContextMenuStrip RC;
        private System.Windows.Forms.ToolStripMenuItem RC_setting;
        private System.Windows.Forms.ToolStripMenuItem RC_reboot;
        private System.Windows.Forms.ToolStripMenuItem RC_Sites;
        private System.Windows.Forms.ToolStripMenuItem RC_UmisiruMap;
        private System.Windows.Forms.ToolStripSeparator RCbar;
        private System.Windows.Forms.ToolStripMenuItem RC_Twitter;
        private System.Windows.Forms.ToolStripMenuItem RC_GitHub;
        private System.Windows.Forms.ToolStripMenuItem RC_SaveSize;
        private System.Windows.Forms.PictureBox SnetImgColor;
        private System.Windows.Forms.Timer ImgChange;
    }
}

