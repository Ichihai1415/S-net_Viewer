using S_net_Viewer.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace S_net_Viewer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplayWidth.Value = Settings.Default.MainSize.Width;
            DisplayHeight.Value = Settings.Default.MainSize.Height;
            if (Settings.Default.MaxSize)
                DisplayMax.Checked = true;
            else
                DisplayMax.Checked = false;
            Delay.Value = Settings.Default.GetDelay;
            if (Settings.Default.ViewTime)
                DisplayTime.Checked = true;
            else
                DisplayTime.Checked = false;
            Color_Back.BackColor = Settings.Default.BackColor;
            Color_Fore.BackColor = Settings.Default.ForeColor;
            ReplaceColor.Checked = Settings.Default.ReplaceColor;
            ReplaceColors.Text = Settings.Default.ReplaceColors;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Settings.Default.MainSize = new Size((int)DisplayWidth.Value, (int)DisplayHeight.Value);
            if (DisplayMax.Checked)
                Settings.Default.MaxSize = true;
            else
                Settings.Default.MaxSize = false;
            Settings.Default.GetDelay = (int)Delay.Value;
            if (DisplayTime.Checked)
                Settings.Default.ViewTime = true;
            else
                Settings.Default.ViewTime = false;
            Settings.Default.BackColor = Color_Back.BackColor;
            Settings.Default.ForeColor = Color_Fore.BackColor;
            Settings.Default.ReplaceColor = ReplaceColor.Checked;
            Settings.Default.ReplaceColors = ReplaceColors.Text;
            Settings.Default.Save();
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            File.Copy(Config.FilePath, "setting.xml", true);
            MessageBox.Show("設定を保存しました。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackColorChange_Click(object sender, EventArgs e)
        {
            DialogResult Color = ColorDialog.ShowDialog();
            if (Color == DialogResult.OK)
                Color_Back.BackColor = ColorDialog.Color;
        }

        private void ForeColorChange_Click(object sender, EventArgs e)
        {
            DialogResult Color = ColorDialog.ShowDialog();
            if (Color == DialogResult.OK)
                Color_Fore.BackColor = ColorDialog.Color;
        }

        private void UmiSiru_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.msil.go.jp/msil/htm/main.html?Lang=0");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var dResult = MessageBox.Show("リセットしてもよろしいですか？\nリセットすると設定画面を開き直します。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dResult == DialogResult.Yes)
            {
                Settings.Default.Reset();
                var setting = new SettingForm();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                if (File.Exists("setting.xml"))
                    File.Delete("setting.xml");
                if (File.Exists(config.FilePath))
                    File.Delete(config.FilePath);
                setting.Show();
                Close();
            }
        }
    }
}
