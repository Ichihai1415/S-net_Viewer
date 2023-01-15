using S_net_Viewer.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace S_net_Viewer
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Timer.Interval != 180000)
                Timer.Interval = 180000;
            GetImg();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            Timer.Interval = 1000 * (60 * (3 - (DateTime.Now.Minute % 3)) - DateTime.Now.Second + Settings.Default.GetDelay);//3x分+遅延までのミリ秒
            ImgChange.Interval = 5000 - (DateTime.Now.Millisecond & 5000);
            SettingReload();
            GetImg();
        }
        /// <summary>
        /// 画像を取得します。
        /// </summary>
        public void GetImg()
        {
            try
            {
                DateTime NowTime = DateTime.Now.ToUniversalTime();
                DateTime DataTime = NowTime - TimeSpan.FromSeconds(DateTime.Now.Second);
                if (DateTime.Now.Second < Settings.Default.GetDelay - 3)//遅延秒より秒が短い
                    DataTime -= TimeSpan.FromMinutes(1);
                DateTime UnixTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long Time = (long)DataTime.Subtract(UnixTime).TotalMilliseconds;
                string KyoshinURL = Settings.Default.URL.Replace("{Time}", $"{Time}").Replace("{Size}", $"{Settings.Default.MainSize.Width},{Settings.Default.MainSize.Height}");
                WebClient wc = new WebClient();
                Stream Kyoshin1 = wc.OpenRead(KyoshinURL);
                Bitmap NormalImg = new Bitmap(Kyoshin1);
                SnetImg.BackgroundImage = NormalImg;
                if (Settings.Default.ReplaceColor)
                {
                    Bitmap ChangeImg = new Bitmap(NormalImg.Width, NormalImg.Height);
                    Graphics graphics = Graphics.FromImage(ChangeImg);
                    ImageAttributes ImageAttributes = new ImageAttributes();
                    ImageAttributes.SetRemapTable(ChangeColors);
                    graphics.DrawImage(NormalImg, new Rectangle(0, 0, NormalImg.Width, NormalImg.Height), 0, 0, NormalImg.Width, NormalImg.Height, GraphicsUnit.Pixel, ImageAttributes);
                    ChangeImg.MakeTransparent(Color.FromArgb(0, 0, 0));
                    SnetImgColor.BackgroundImage = ChangeImg;
                    graphics.Dispose();
                }
                if (Settings.Default.ViewTime)
                    this.Time.Text = $"{DataTime.ToLocalTime():yyyy/MM/dd HH:mm}\n取得遅延:{Settings.Default.GetDelay}s";
                wc.Dispose();
                Kyoshin1.Dispose();
            }
            catch (WebException ex)
            {
                Time.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Time.Text = ex.Message;
                if (!Directory.Exists("Log"))
                    Directory.CreateDirectory("Log");
                if (!Directory.Exists("Log\\ErrorLog"))
                    Directory.CreateDirectory("Log\\ErrorLog");
                if (!Directory.Exists($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}"))
                    Directory.CreateDirectory($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}");
                if (File.Exists($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt"))
                    File.WriteAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt", File.ReadAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt") + "\n--------------------------------------------------\n" + $"{DateTime.Now:HH:mm:ss} {ex}");
                else
                    File.WriteAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt", $"{DateTime.Now:HH:mm:ss} {ex}");
            }
        }
        public ColorMap[] ChangeColors;
        /// <summary>
        /// 設定を読み込みます。
        /// </summary>
        public void SettingReload()
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            if (File.Exists("setting.xml"))
            {
                if (!Directory.Exists(Config.FilePath.Replace("\\user.config", "")))
                    Directory.CreateDirectory(Config.FilePath.Replace("\\user.config", ""));
                File.Copy("setting.xml", Config.FilePath, true);
                Settings.Default.Reload();
            }
            if (Settings.Default.MaxSize)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            ClientSize = Settings.Default.MainSize;
            BackColor = Settings.Default.BackColor;
            SnetImg.BackColor = Settings.Default.BackColor;
            SnetImgColor.BackColor = Settings.Default.BackColor;
            Time.BackColor = Settings.Default.BackColor;
            ForeColor = Settings.Default.ForeColor;
            Time.ForeColor = Settings.Default.ForeColor;
            List<ColorMap> ColorChange = new List<ColorMap>();
            string[] Colors_ = Settings.Default.ReplaceColors.Replace("\n", "").Split('/');
            for (int i = 0; i * 2 < Colors_.Count(); i++)
            {
                string[] Colors1 = Colors_[i * 2].Split(',');
                string[] Colors2 = Colors_[i * 2 + 1].Split(',');
                ColorChange.Add(new ColorMap());
                ColorChange[i].OldColor = Color.FromArgb(Convert.ToInt16(Colors1[0]), Convert.ToInt16(Colors1[1]), Convert.ToInt16(Colors1[2]));
                ColorChange[i].NewColor = Color.FromArgb(Convert.ToInt16(Colors2[0]), Convert.ToInt16(Colors2[1]), Convert.ToInt16(Colors2[2]));
            }
            ChangeColors = ColorChange.ToArray();
        }
        private void Display_Resize(object sender, EventArgs e)
        {
            SnetImg.Size = ClientSize;
            SnetImgColor.Size = ClientSize;
        }

        private void RC_setting_Click(object sender, EventArgs e)
        {
            SettingForm Setting = new SettingForm();
            Setting.FormClosed += Setting_FormClosing;//閉じたとき呼び出し
            Setting.Show();
        }
        private void Setting_FormClosing(object sender, FormClosedEventArgs e)
        {
            SettingReload();
            GetImg();
        }
        private void RC_reboot_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void RC_UmisiruMap_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.msil.go.jp/msil/htm/main.html?Lang=0");
        }

        private void RC_Twitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ProjectS31415_1");
        }

        private void RC_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ichihai1415/S-net_Viewer");
        }

        private void RC_SaveSize_Click(object sender, EventArgs e)
        {
            Settings.Default.MainSize = ClientSize;
            Settings.Default.Save();
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            File.Copy(Config.FilePath, "setting.xml", true);
        }

        private void Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.MainSize = ClientSize;
            Settings.Default.Save();
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            File.Copy(Config.FilePath, "setting.xml", true);
        }

        private void ImgChange_Tick(object sender, EventArgs e)
        {
            ImgChange.Interval = 5000 - (DateTime.Now.Millisecond & 5000);
            if (DateTime.Now.Second % 10 < 5)//通常
                SnetImgColor.Size = new Size(0, 0);
            else if (Settings.Default.ReplaceColor)
                SnetImgColor.Size = SnetImg.Size;
        }
    }
}
