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
            components = new System.ComponentModel.Container();
            SnetImg = new System.Windows.Forms.PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            L_infos = new System.Windows.Forms.Label();
            RC = new System.Windows.Forms.ContextMenuStrip(components);
            RC_setting = new System.Windows.Forms.ToolStripMenuItem();
            RC_SaveSize = new System.Windows.Forms.ToolStripMenuItem();
            RC_Sites = new System.Windows.Forms.ToolStripMenuItem();
            RC_UmisiruMap = new System.Windows.Forms.ToolStripMenuItem();
            RCbar = new System.Windows.Forms.ToolStripSeparator();
            RC_Twitter = new System.Windows.Forms.ToolStripMenuItem();
            RC_GitHub = new System.Windows.Forms.ToolStripMenuItem();
            RC_reboot = new System.Windows.Forms.ToolStripMenuItem();
            SnetImgColor = new System.Windows.Forms.PictureBox();
            ImgChange = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SnetImg).BeginInit();
            RC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SnetImgColor).BeginInit();
            SuspendLayout();
            // 
            // SnetImg
            // 
            SnetImg.BackColor = System.Drawing.Color.FromArgb(45, 45, 90);
            SnetImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            SnetImg.Dock = System.Windows.Forms.DockStyle.Fill;
            SnetImg.Location = new System.Drawing.Point(0, 0);
            SnetImg.Margin = new System.Windows.Forms.Padding(4);
            SnetImg.Name = "SnetImg";
            SnetImg.Size = new System.Drawing.Size(180, 320);
            SnetImg.TabIndex = 0;
            SnetImg.TabStop = false;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // L_infos
            // 
            L_infos.AutoSize = true;
            L_infos.Location = new System.Drawing.Point(0, 0);
            L_infos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            L_infos.Name = "L_infos";
            L_infos.Size = new System.Drawing.Size(129, 30);
            L_infos.TabIndex = 1;
            L_infos.Text = "---- / -- / --  -- : -- \r\n最大:  - - . - ( - - - - - - )";
            // 
            // RC
            // 
            RC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { RC_setting, RC_SaveSize, RC_Sites, RC_reboot });
            RC.Name = "RC";
            RC.Size = new System.Drawing.Size(189, 92);
            // 
            // RC_setting
            // 
            RC_setting.Name = "RC_setting";
            RC_setting.Size = new System.Drawing.Size(188, 22);
            RC_setting.Text = "設定";
            RC_setting.Click += RC_setting_Click;
            // 
            // RC_SaveSize
            // 
            RC_SaveSize.Name = "RC_SaveSize";
            RC_SaveSize.Size = new System.Drawing.Size(188, 22);
            RC_SaveSize.Text = "現在のサイズを設定する";
            RC_SaveSize.Click += RC_SaveSize_Click;
            // 
            // RC_Sites
            // 
            RC_Sites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { RC_UmisiruMap, RCbar, RC_Twitter, RC_GitHub });
            RC_Sites.Name = "RC_Sites";
            RC_Sites.Size = new System.Drawing.Size(188, 22);
            RC_Sites.Text = "各種サイト";
            // 
            // RC_UmisiruMap
            // 
            RC_UmisiruMap.Name = "RC_UmisiruMap";
            RC_UmisiruMap.Size = new System.Drawing.Size(157, 22);
            RC_UmisiruMap.Text = "海しるマップ";
            RC_UmisiruMap.Click += RC_UmisiruMap_Click;
            // 
            // RCbar
            // 
            RCbar.Name = "RCbar";
            RCbar.Size = new System.Drawing.Size(154, 6);
            // 
            // RC_Twitter
            // 
            RC_Twitter.Name = "RC_Twitter";
            RC_Twitter.Size = new System.Drawing.Size(157, 22);
            RC_Twitter.Text = "製作者Twitter";
            RC_Twitter.Click += RC_Twitter_Click;
            // 
            // RC_GitHub
            // 
            RC_GitHub.Name = "RC_GitHub";
            RC_GitHub.Size = new System.Drawing.Size(157, 22);
            RC_GitHub.Text = "GitHubレポジトリ";
            RC_GitHub.Click += RC_GitHub_Click;
            // 
            // RC_reboot
            // 
            RC_reboot.Name = "RC_reboot";
            RC_reboot.Size = new System.Drawing.Size(188, 22);
            RC_reboot.Text = "再起動";
            RC_reboot.Click += RC_reboot_Click;
            // 
            // SnetImgColor
            // 
            SnetImgColor.BackColor = System.Drawing.Color.FromArgb(45, 45, 90);
            SnetImgColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            SnetImgColor.Location = new System.Drawing.Point(0, 0);
            SnetImgColor.Margin = new System.Windows.Forms.Padding(4);
            SnetImgColor.Name = "SnetImgColor";
            SnetImgColor.Size = new System.Drawing.Size(0, 0);
            SnetImgColor.TabIndex = 2;
            SnetImgColor.TabStop = false;
            // 
            // ImgChange
            // 
            ImgChange.Enabled = true;
            ImgChange.Interval = 10000;
            ImgChange.Tick += ImgChange_Tick;
            // 
            // Display
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 90);
            ClientSize = new System.Drawing.Size(180, 320);
            ContextMenuStrip = RC;
            Controls.Add(L_infos);
            Controls.Add(SnetImgColor);
            Controls.Add(SnetImg);
            ForeColor = System.Drawing.Color.White;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Display";
            Text = "S-net Viewer";
            FormClosing += Display_FormClosing;
            Load += Display_Load;
            Resize += Display_Resize;
            ((System.ComponentModel.ISupportInitialize)SnetImg).EndInit();
            RC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SnetImgColor).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SnetImg;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label L_infos;
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

