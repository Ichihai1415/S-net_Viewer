namespace S_net_Viewer
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.Save = new System.Windows.Forms.Button();
            this.InfoText2 = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Color_Back = new System.Windows.Forms.Label();
            this.DisplayWidth = new System.Windows.Forms.NumericUpDown();
            this.DisplayHeight = new System.Windows.Forms.NumericUpDown();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.UmiSiru = new System.Windows.Forms.LinkLabel();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.DisplayTime = new System.Windows.Forms.CheckBox();
            this.DisplayMax = new System.Windows.Forms.CheckBox();
            this.Color_Fore = new System.Windows.Forms.Label();
            this.BackColorChange = new System.Windows.Forms.Button();
            this.ForeColorChange = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ReplaceColor = new System.Windows.Forms.CheckBox();
            this.ReplaceColors = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(13, 318);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 0;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // InfoText2
            // 
            this.InfoText2.AutoSize = true;
            this.InfoText2.Location = new System.Drawing.Point(134, 318);
            this.InfoText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoText2.Name = "InfoText2";
            this.InfoText2.Size = new System.Drawing.Size(367, 28);
            this.InfoText2.TabIndex = 1;
            this.InfoText2.Text = "※このウィンドウを閉じると設定が再読み込みされます。\r\n　画像が表示されない場合再起動するかURLを確認してください。\r\n";
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(20, 20);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(600, 320);
            this.InfoText.TabIndex = 2;
            this.InfoText.Text = resources.GetString("InfoText.Text");
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.FullOpen = true;
            // 
            // Color_Back
            // 
            this.Color_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.Color_Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_Back.Location = new System.Drawing.Point(71, 102);
            this.Color_Back.Name = "Color_Back";
            this.Color_Back.Size = new System.Drawing.Size(20, 20);
            this.Color_Back.TabIndex = 3;
            // 
            // DisplayWidth
            // 
            this.DisplayWidth.Location = new System.Drawing.Point(124, 18);
            this.DisplayWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DisplayWidth.Name = "DisplayWidth";
            this.DisplayWidth.Size = new System.Drawing.Size(48, 21);
            this.DisplayWidth.TabIndex = 5;
            this.DisplayWidth.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // DisplayHeight
            // 
            this.DisplayHeight.Location = new System.Drawing.Point(188, 18);
            this.DisplayHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DisplayHeight.Name = "DisplayHeight";
            this.DisplayHeight.Size = new System.Drawing.Size(48, 21);
            this.DisplayHeight.TabIndex = 6;
            this.DisplayHeight.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(23, 262);
            this.URLbox.Multiline = true;
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(597, 44);
            this.URLbox.TabIndex = 7;
            this.URLbox.Text = resources.GetString("URLbox.Text");
            // 
            // UmiSiru
            // 
            this.UmiSiru.AutoSize = true;
            this.UmiSiru.Location = new System.Drawing.Point(106, 187);
            this.UmiSiru.Name = "UmiSiru";
            this.UmiSiru.Size = new System.Drawing.Size(303, 14);
            this.UmiSiru.TabIndex = 8;
            this.UmiSiru.TabStop = true;
            this.UmiSiru.Text = "https://www.msil.go.jp/msil/htm/main.html?Lang=0";
            this.UmiSiru.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UmiSiru_LinkClicked);
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(83, 45);
            this.Delay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(48, 21);
            this.Delay.TabIndex = 9;
            this.Delay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // DisplayTime
            // 
            this.DisplayTime.AutoSize = true;
            this.DisplayTime.Checked = true;
            this.DisplayTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayTime.Location = new System.Drawing.Point(23, 75);
            this.DisplayTime.Name = "DisplayTime";
            this.DisplayTime.Size = new System.Drawing.Size(207, 18);
            this.DisplayTime.TabIndex = 10;
            this.DisplayTime.Text = "取得時刻・遅延秒数を表示する";
            this.DisplayTime.UseVisualStyleBackColor = true;
            // 
            // DisplayMax
            // 
            this.DisplayMax.AutoSize = true;
            this.DisplayMax.Location = new System.Drawing.Point(239, 35);
            this.DisplayMax.Name = "DisplayMax";
            this.DisplayMax.Size = new System.Drawing.Size(68, 18);
            this.DisplayMax.TabIndex = 11;
            this.DisplayMax.Text = "最大化";
            this.DisplayMax.UseVisualStyleBackColor = true;
            // 
            // Color_Fore
            // 
            this.Color_Fore.BackColor = System.Drawing.Color.White;
            this.Color_Fore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_Fore.Location = new System.Drawing.Point(209, 102);
            this.Color_Fore.Name = "Color_Fore";
            this.Color_Fore.Size = new System.Drawing.Size(20, 20);
            this.Color_Fore.TabIndex = 12;
            // 
            // BackColorChange
            // 
            this.BackColorChange.Location = new System.Drawing.Point(97, 101);
            this.BackColorChange.Name = "BackColorChange";
            this.BackColorChange.Size = new System.Drawing.Size(50, 23);
            this.BackColorChange.TabIndex = 13;
            this.BackColorChange.Text = "変更";
            this.BackColorChange.UseVisualStyleBackColor = true;
            this.BackColorChange.Click += new System.EventHandler(this.BackColorChange_Click);
            // 
            // ForeColorChange
            // 
            this.ForeColorChange.Location = new System.Drawing.Point(235, 101);
            this.ForeColorChange.Name = "ForeColorChange";
            this.ForeColorChange.Size = new System.Drawing.Size(50, 23);
            this.ForeColorChange.TabIndex = 14;
            this.ForeColorChange.Text = "変更";
            this.ForeColorChange.UseVisualStyleBackColor = true;
            this.ForeColorChange.Click += new System.EventHandler(this.ForeColorChange_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(527, 318);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 30);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "リセット";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ReplaceColor
            // 
            this.ReplaceColor.AutoSize = true;
            this.ReplaceColor.Location = new System.Drawing.Point(23, 140);
            this.ReplaceColor.Name = "ReplaceColor";
            this.ReplaceColor.Size = new System.Drawing.Size(284, 18);
            this.ReplaceColor.TabIndex = 16;
            this.ReplaceColor.Text = "5秒ごとに震度別色に置換した画像を表示する";
            this.ReplaceColor.UseVisualStyleBackColor = true;
            // 
            // ReplaceColors
            // 
            this.ReplaceColors.Location = new System.Drawing.Point(304, 75);
            this.ReplaceColors.Multiline = true;
            this.ReplaceColors.Name = "ReplaceColors";
            this.ReplaceColors.Size = new System.Drawing.Size(323, 109);
            this.ReplaceColors.TabIndex = 17;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 352);
            this.Controls.Add(this.ReplaceColors);
            this.Controls.Add(this.ReplaceColor);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ForeColorChange);
            this.Controls.Add(this.BackColorChange);
            this.Controls.Add(this.Color_Fore);
            this.Controls.Add(this.DisplayMax);
            this.Controls.Add(this.DisplayTime);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.UmiSiru);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.DisplayHeight);
            this.Controls.Add(this.DisplayWidth);
            this.Controls.Add(this.Color_Back);
            this.Controls.Add(this.InfoText2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.InfoText);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 399);
            this.Name = "SettingForm";
            this.Text = "S-net Viewer - 設定";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label InfoText2;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label Color_Back;
        private System.Windows.Forms.NumericUpDown DisplayWidth;
        private System.Windows.Forms.NumericUpDown DisplayHeight;
        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.LinkLabel UmiSiru;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.CheckBox DisplayTime;
        private System.Windows.Forms.CheckBox DisplayMax;
        private System.Windows.Forms.Label Color_Fore;
        private System.Windows.Forms.Button BackColorChange;
        private System.Windows.Forms.Button ForeColorChange;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.CheckBox ReplaceColor;
        private System.Windows.Forms.TextBox ReplaceColors;
    }
}