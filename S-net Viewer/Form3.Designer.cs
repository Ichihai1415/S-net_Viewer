namespace S_net_Viewer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            TB_NumDatas = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // TB_NumDatas
            // 
            TB_NumDatas.Cursor = System.Windows.Forms.Cursors.IBeam;
            TB_NumDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            TB_NumDatas.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            TB_NumDatas.Location = new System.Drawing.Point(0, 0);
            TB_NumDatas.Margin = new System.Windows.Forms.Padding(4);
            TB_NumDatas.Multiline = true;
            TB_NumDatas.Name = "TB_NumDatas";
            TB_NumDatas.ReadOnly = true;
            TB_NumDatas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TB_NumDatas.Size = new System.Drawing.Size(240, 480);
            TB_NumDatas.TabIndex = 0;
            TB_NumDatas.Text = resources.GetString("TB_NumDatas.Text");
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(240, 480);
            Controls.Add(TB_NumDatas);
            Margin = new System.Windows.Forms.Padding(4);
            MaximumSize = new System.Drawing.Size(256, 9999);
            Name = "Form3";
            Text = "SNV-観測点データ";
            FormClosed += Form3_FormClosed;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NumDatas;
    }
}