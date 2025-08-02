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
            Save = new System.Windows.Forms.Button();
            InfoText2 = new System.Windows.Forms.Label();
            InfoText = new System.Windows.Forms.Label();
            ColorDialog = new System.Windows.Forms.ColorDialog();
            Color_Back = new System.Windows.Forms.Label();
            DisplayWidth = new System.Windows.Forms.NumericUpDown();
            DisplayHeight = new System.Windows.Forms.NumericUpDown();
            Delay = new System.Windows.Forms.NumericUpDown();
            DisplayTime = new System.Windows.Forms.CheckBox();
            DisplayMax = new System.Windows.Forms.CheckBox();
            Color_Fore = new System.Windows.Forms.Label();
            BackColorChange = new System.Windows.Forms.Button();
            ForeColorChange = new System.Windows.Forms.Button();
            Reset = new System.Windows.Forms.Button();
            ReplaceColor = new System.Windows.Forms.CheckBox();
            ReplaceColors = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)DisplayWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisplayHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Delay).BeginInit();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new System.Drawing.Point(13, 198);
            Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(100, 30);
            Save.TabIndex = 0;
            Save.Text = "保存";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // InfoText2
            // 
            InfoText2.AutoSize = true;
            InfoText2.Location = new System.Drawing.Point(117, 200);
            InfoText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            InfoText2.Name = "InfoText2";
            InfoText2.Size = new System.Drawing.Size(401, 28);
            InfoText2.TabIndex = 1;
            InfoText2.Text = "※このウィンドウを閉じると設定が再読み込みされます。\r\n　画像が表示されない場合再起動するか取得遅延を大きくしてください。\r\n";
            // 
            // InfoText
            // 
            InfoText.Location = new System.Drawing.Point(20, 20);
            InfoText.Name = "InfoText";
            InfoText.Size = new System.Drawing.Size(600, 178);
            InfoText.TabIndex = 2;
            InfoText.Text = resources.GetString("InfoText.Text");
            // 
            // ColorDialog
            // 
            ColorDialog.AnyColor = true;
            ColorDialog.FullOpen = true;
            // 
            // Color_Back
            // 
            Color_Back.BackColor = System.Drawing.Color.FromArgb(45, 45, 90);
            Color_Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Color_Back.Location = new System.Drawing.Point(71, 102);
            Color_Back.Name = "Color_Back";
            Color_Back.Size = new System.Drawing.Size(20, 20);
            Color_Back.TabIndex = 3;
            // 
            // DisplayWidth
            // 
            DisplayWidth.Location = new System.Drawing.Point(124, 18);
            DisplayWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            DisplayWidth.Name = "DisplayWidth";
            DisplayWidth.Size = new System.Drawing.Size(48, 21);
            DisplayWidth.TabIndex = 5;
            DisplayWidth.Value = new decimal(new int[] { 180, 0, 0, 0 });
            // 
            // DisplayHeight
            // 
            DisplayHeight.Location = new System.Drawing.Point(188, 18);
            DisplayHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            DisplayHeight.Name = "DisplayHeight";
            DisplayHeight.Size = new System.Drawing.Size(48, 21);
            DisplayHeight.TabIndex = 6;
            DisplayHeight.Value = new decimal(new int[] { 320, 0, 0, 0 });
            // 
            // Delay
            // 
            Delay.Location = new System.Drawing.Point(83, 45);
            Delay.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Delay.Name = "Delay";
            Delay.Size = new System.Drawing.Size(48, 21);
            Delay.TabIndex = 9;
            Delay.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // DisplayTime
            // 
            DisplayTime.AutoSize = true;
            DisplayTime.Checked = true;
            DisplayTime.CheckState = System.Windows.Forms.CheckState.Checked;
            DisplayTime.Location = new System.Drawing.Point(23, 75);
            DisplayTime.Name = "DisplayTime";
            DisplayTime.Size = new System.Drawing.Size(207, 18);
            DisplayTime.TabIndex = 10;
            DisplayTime.Text = "取得時刻・遅延秒数を表示する";
            DisplayTime.UseVisualStyleBackColor = true;
            // 
            // DisplayMax
            // 
            DisplayMax.AutoSize = true;
            DisplayMax.Location = new System.Drawing.Point(239, 35);
            DisplayMax.Name = "DisplayMax";
            DisplayMax.Size = new System.Drawing.Size(68, 18);
            DisplayMax.TabIndex = 11;
            DisplayMax.Text = "最大化";
            DisplayMax.UseVisualStyleBackColor = true;
            // 
            // Color_Fore
            // 
            Color_Fore.BackColor = System.Drawing.Color.White;
            Color_Fore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Color_Fore.Location = new System.Drawing.Point(209, 102);
            Color_Fore.Name = "Color_Fore";
            Color_Fore.Size = new System.Drawing.Size(20, 20);
            Color_Fore.TabIndex = 12;
            // 
            // BackColorChange
            // 
            BackColorChange.Location = new System.Drawing.Point(97, 101);
            BackColorChange.Name = "BackColorChange";
            BackColorChange.Size = new System.Drawing.Size(50, 23);
            BackColorChange.TabIndex = 13;
            BackColorChange.Text = "変更";
            BackColorChange.UseVisualStyleBackColor = true;
            BackColorChange.Click += BackColorChange_Click;
            // 
            // ForeColorChange
            // 
            ForeColorChange.Location = new System.Drawing.Point(235, 101);
            ForeColorChange.Name = "ForeColorChange";
            ForeColorChange.Size = new System.Drawing.Size(50, 23);
            ForeColorChange.TabIndex = 14;
            ForeColorChange.Text = "変更";
            ForeColorChange.UseVisualStyleBackColor = true;
            ForeColorChange.Click += ForeColorChange_Click;
            // 
            // Reset
            // 
            Reset.Location = new System.Drawing.Point(527, 198);
            Reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(100, 30);
            Reset.TabIndex = 15;
            Reset.Text = "リセット";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // ReplaceColor
            // 
            ReplaceColor.AutoSize = true;
            ReplaceColor.Location = new System.Drawing.Point(23, 131);
            ReplaceColor.Name = "ReplaceColor";
            ReplaceColor.Size = new System.Drawing.Size(284, 18);
            ReplaceColor.TabIndex = 16;
            ReplaceColor.Text = "5秒ごとに震度別色に置換した画像を表示する";
            ReplaceColor.UseVisualStyleBackColor = true;
            // 
            // ReplaceColors
            // 
            ReplaceColors.Location = new System.Drawing.Point(304, 75);
            ReplaceColors.Multiline = true;
            ReplaceColors.Name = "ReplaceColors";
            ReplaceColors.Size = new System.Drawing.Size(323, 109);
            ReplaceColors.TabIndex = 17;
            ReplaceColors.Text = "(自動で設定を読み込み表示されます)";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 240);
            Controls.Add(ReplaceColors);
            Controls.Add(ReplaceColor);
            Controls.Add(Reset);
            Controls.Add(ForeColorChange);
            Controls.Add(BackColorChange);
            Controls.Add(Color_Fore);
            Controls.Add(DisplayMax);
            Controls.Add(DisplayTime);
            Controls.Add(Delay);
            Controls.Add(DisplayHeight);
            Controls.Add(DisplayWidth);
            Controls.Add(Color_Back);
            Controls.Add(InfoText2);
            Controls.Add(Save);
            Controls.Add(InfoText);
            Font = new System.Drawing.Font("MS UI Gothic", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SettingForm";
            Text = "S-net Viewer - 設定";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisplayHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)Delay).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label InfoText2;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label Color_Back;
        private System.Windows.Forms.NumericUpDown DisplayWidth;
        private System.Windows.Forms.NumericUpDown DisplayHeight;
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