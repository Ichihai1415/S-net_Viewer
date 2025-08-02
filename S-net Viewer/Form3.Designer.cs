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
            this.TB_NumDatas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_NumDatas
            // 
            this.TB_NumDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NumDatas.Location = new System.Drawing.Point(0, 0);
            this.TB_NumDatas.Multiline = true;
            this.TB_NumDatas.Name = "TB_NumDatas";
            this.TB_NumDatas.ReadOnly = true;
            this.TB_NumDatas.Size = new System.Drawing.Size(200, 400);
            this.TB_NumDatas.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 400);
            this.Controls.Add(this.TB_NumDatas);
            this.Name = "Form3";
            this.Text = "SNV-観測点データ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NumDatas;
    }
}