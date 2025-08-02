using S_net_Viewer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            //Timer.Interval = 1000 * (60 - DateTime.Now.Second + Settings.Default.GetDelay);//臨時1分ごと
            Timer.Interval = 1000 * (60 * (3 - (DateTime.Now.Minute % 3)) - DateTime.Now.Second + Settings.Default.GetDelay);//3x分+遅延までのミリ秒
            GetImg();
        }

        internal Form3 ObsValues = new();

        private void Display_Load(object sender, EventArgs e)
        {
            Timer.Interval = 1000 * (60 * (3 - (DateTime.Now.Minute % 3)) - DateTime.Now.Second + Settings.Default.GetDelay);//3x分+遅延までのミリ秒
            //Timer.Interval = 1000 * (60 - DateTime.Now.Second + Settings.Default.GetDelay);//臨時1分ごと
            ImgChange.Interval = 5000 - (DateTime.Now.Millisecond & 5000);
            SettingReload();
            GetImg();
            ObsValues.Show();
        }

        /*
        /// <summary>
        /// 画像を取得します。
        /// </summary>
        public void GetImg()
        {
            try
            {
                if (DateTime.Now.Minute % 3 == 1)
                    ;//return;
                DateTime NowTime = DateTime.Now.ToUniversalTime();
                DateTime DataTime = NowTime - TimeSpan.FromSeconds(DateTime.Now.Second);
                if (DateTime.Now.Second < Settings.Default.GetDelay - 3)//遅延秒より秒が短い
                    DataTime -= TimeSpan.FromMinutes(1);
                DateTime UnixTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long Time = (long)DataTime.Subtract(UnixTime).TotalMilliseconds;
                string KyoshinURL = Settings.Default.URL.Replace("{Time}", $"{Time}").Replace("{Size}", $"{Settings.Default.MainSize.Width},{Settings.Default.MainSize.Height}");
                WebClient wc = new();
                Stream Kyoshin1 = wc.OpenRead(KyoshinURL);
                Bitmap NormalImg = new(Kyoshin1);
                SnetImg.BackgroundImage = NormalImg;
                if (Settings.Default.ReplaceColor)
                {
                    Bitmap ChangeImg = new(NormalImg.Width, NormalImg.Height);
                    Graphics graphics = Graphics.FromImage(ChangeImg);
                    ImageAttributes ImageAttributes = new();
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
        }*/

        internal static HttpClient client = new();
        internal static ImageAttributes IA = new();

        /// <summary>
        /// 画像を取得します。
        /// </summary>
        public async void GetImg()
        {
            try
            {
                var nowTime = DateTime.Now;
                var nowTimeUniv = nowTime.ToUniversalTime();
                var dataTime = nowTimeUniv - TimeSpan.FromSeconds(nowTimeUniv.Second);
                if (nowTime.Second < Settings.Default.GetDelay - 1)//遅延秒より秒が短い
                    dataTime -= TimeSpan.FromMinutes(1);
                var time = dataTime.ToString("yyyyMMddHHmm") + "00";
                var kyoshinURL1 = $"https://www.msil.go.jp/tiles/smoni/" + time + "/" + time + "/5/28/11.png";
                var kyoshinURL2 = $"https://www.msil.go.jp/tiles/smoni/" + time + "/" + time + "/5/28/12.png";

                var mainImg_normal = new Bitmap(180, 320);
                using var g = Graphics.FromImage(mainImg_normal);
                using var img1 = new Bitmap(await client.GetStreamAsync(kyoshinURL1));
                using var img2 = new Bitmap(await client.GetStreamAsync(kyoshinURL2));
                //Console.WriteLine(img1.Width);
                //Console.WriteLine(img2.Width);
                g.DrawImage(img1, -86, -164, 256, 256);
                g.DrawImage(img2, -86, 92, 256, 256);
                SnetImg.BackgroundImage = mainImg_normal;

                if (Settings.Default.ReplaceColor)
                {
                    var changeImg = new Bitmap(mainImg_normal.Width, mainImg_normal.Height);
                    using var g_rp = Graphics.FromImage(changeImg);
                    g_rp.DrawImage(mainImg_normal, new Rectangle(0, 0, mainImg_normal.Width, mainImg_normal.Height), 0, 0, mainImg_normal.Width, mainImg_normal.Height, GraphicsUnit.Pixel, IA);
                    changeImg.MakeTransparent(Color.FromArgb(0, 0, 0));
                    SnetImgColor.BackgroundImage = changeImg;
                }

                var dict = new Dictionary<string, double>();
                foreach (var obsPt in obsPoints.Tiles.Z5.X28.Y11)
                {
                    Debug.WriteLine(obsPt.X + "," + obsPt.Y);
                    var pointColor = img1.GetPixel(obsPt.X, obsPt.Y);
                    if (Converter.RGB2Sindo.TryGetValue([pointColor.R, pointColor.G, pointColor.B], out double sindo))
                        dict.Add(obsPt.Name, sindo);
                }
                foreach (var obsPt in obsPoints.Tiles.Z5.X28.Y12)
                {
                    var pointColor = img2.GetPixel(obsPt.X, obsPt.Y);
                    if (Converter.RGB2Sindo.TryGetValue([pointColor.R, pointColor.G, pointColor.B], out double sindo))
                        dict.Add(obsPt.Name, sindo);
                }

                dict = dict.OrderByDescending(x => x.Value).ToDictionary();
                ObsValues.ValueChange(dataTime.ToLocalTime().ToString("yyyy/MM/dd HH:mm"), dict);

                if (Settings.Default.ViewTime)
                    L_infos.Text = $"{dataTime.ToLocalTime():yyyy/MM/dd HH:mm}\n最大: {dict.First().Value:0.0} ({dict.First().Key})";
            }
            catch (WebException ex)
            {
                L_infos.Text = ex.Message;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                L_infos.Text = ex.Message;
            }
            catch (Exception ex)
            {
                L_infos.Text = ex.Message;
                Directory.CreateDirectory($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}");
                if (File.Exists($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt"))
                    File.WriteAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt", File.ReadAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt") + "\n--------------------------------------------------\n" + $"{DateTime.Now:HH:mm:ss} {ex}");
                else
                    File.WriteAllText($"Log\\ErrorLog\\{DateTime.Now:yyyyMM}\\{DateTime.Now:yyyyMMdd}.txt", $"{DateTime.Now:HH:mm:ss} {ex}");
            }
            GC.Collect();
        }


        internal static ObsPoints obsPoints = new();

        /// <summary>
        /// 設定を読み込みます。
        /// </summary>
        public void SettingReload()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            if (File.Exists("setting.xml"))
            {
                if (!Directory.Exists(config.FilePath.Replace("\\user.config", "")))
                    Directory.CreateDirectory(config.FilePath.Replace("\\user.config", ""));
                File.Copy("setting.xml", config.FilePath, true);
                Settings.Default.Reload();
            }
            if (Settings.Default.MaxSize)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            ClientSize = Settings.Default.MainSize;
            L_infos.MaximumSize = ClientSize;
            BackColor = Settings.Default.BackColor;
            SnetImg.BackColor = Settings.Default.BackColor;
            SnetImgColor.BackColor = Settings.Default.BackColor;
            L_infos.BackColor = Settings.Default.BackColor;
            ForeColor = Settings.Default.ForeColor;
            L_infos.ForeColor = Settings.Default.ForeColor;
            var colorChange = new List<ColorMap>();
            var colorsSt = Settings.Default.ReplaceColors.Replace("\n", "").Split('/');
            for (int i = 0; i * 2 < colorsSt.Length; i++)
            {
                var colors1 = colorsSt[i * 2].Split(',');
                var colors2 = colorsSt[i * 2 + 1].Split(',');
                colorChange.Add(new ColorMap()
                {
                    OldColor = Color.FromArgb(int.Parse(colors1[0]), int.Parse(colors1[1]), int.Parse(colors1[2])),
                    NewColor = Color.FromArgb(int.Parse(colors2[0]), int.Parse(colors2[1]), int.Parse(colors2[2]))
                });
            }
            IA.SetRemapTable(colorChange.ToArray());

            var rm = new ResourceManager("S_net_Viewer.Properties.Resources", typeof(Program).Assembly);
            var obsPtSt = rm.GetString("ObsPointsSt");
            if (File.Exists("ObsPoints.json"))
                obsPtSt = File.ReadAllText("ObsPoints.json");
            else
                File.WriteAllText("ObsPoints.json", obsPtSt);
            obsPoints = JsonSerializer.Deserialize<ObsPoints>(obsPtSt);
        }

        private void Display_Resize(object sender, EventArgs e)
        {
            SnetImg.Size = ClientSize;
            SnetImgColor.Size = ClientSize;
        }

        private void RC_setting_Click(object sender, EventArgs e)
        {
            SettingForm Setting = new();
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

    /// <summary>
    /// タイルデータでの観測点座標データ
    /// </summary>
    public class ObsPoints
    {
        [JsonPropertyName("updated")]
        public string Updated { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tiles")]
        public C_Tiles Tiles { get; set; }

        public class C_Tiles
        {
            [JsonPropertyName("z5")]
            public C_Z5 Z5 { get; set; }

            public class C_Z5
            {
                [JsonPropertyName("x28")]
                public C_X28 X28 { get; set; }
            }

            public class C_X28
            {
                [JsonPropertyName("y11")]
                public C_Y[] Y11 { get; set; }

                [JsonPropertyName("y12")]
                public C_Y[] Y12 { get; set; }
            }

            public class C_Y
            {
                [JsonPropertyName("name")]
                public string Name { get; set; }

                [JsonPropertyName("x")]
                public int X { get; set; }

                [JsonPropertyName("y")]
                public int Y { get; set; }
            }
        }
    }

    public class Converter
    {
        /// <summary>
        /// 強震モニタリアルタイム震度色から震度へ
        /// </summary>
        /// <remarks>データ:https://github.com/ingen084/KyoshinShindoColorMap</remarks>
        public static readonly Dictionary<int[], double> RGB2Sindo = new(new ArrayEqualityComparer<int>())
        {
            { new int[] {0, 0, 0}, -9.9},
            { new int[] {0, 0, 205}, -3.0},
            { new int[] {0, 7, 209}, -2.9},
            { new int[] {0, 14, 214}, -2.8},
            { new int[] {0, 21, 218}, -2.7},
            { new int[] {0, 28, 223}, -2.6},
            { new int[] {0, 36, 227}, -2.5},
            { new int[] {0, 43, 231}, -2.4},
            { new int[] {0, 50, 236}, -2.3},
            { new int[] {0, 57, 240}, -2.2},
            { new int[] {0, 64, 245}, -2.1},
            { new int[] {0, 72, 250}, -2.0},
            { new int[] {0, 85, 238}, -1.9},
            { new int[] {0, 99, 227}, -1.8},
            { new int[] {0, 112, 216}, -1.7},
            { new int[] {0, 126, 205}, -1.6},
            { new int[] {0, 140, 194}, -1.5},
            { new int[] {0, 153, 183}, -1.4},
            { new int[] {0, 167, 172}, -1.3},
            { new int[] {0, 180, 161}, -1.2},
            { new int[] {0, 194, 150}, -1.1},
            { new int[] {0, 208, 139}, -1.0},
            { new int[] {6, 212, 130}, -0.9},
            { new int[] {12, 216, 121}, -0.8},
            { new int[] {18, 220, 113}, -0.7},
            { new int[] {25, 224, 104}, -0.6},
            { new int[] {31, 228, 96}, -0.5},
            { new int[] {37, 233, 88}, -0.4},
            { new int[] {44, 237, 79}, -0.3},
            { new int[] {50, 241, 71}, -0.2},
            { new int[] {56, 245, 62}, -0.1},
            { new int[] {63, 250, 54}, 0.0},
            { new int[] {75, 250, 49}, 0.1},
            { new int[] {88, 250, 45}, 0.2},
            { new int[] {100, 251, 41}, 0.3},
            { new int[] {113, 251, 37}, 0.4},
            { new int[] {125, 252, 33}, 0.5},
            { new int[] {138, 252, 28}, 0.6},
            { new int[] {151, 253, 24}, 0.7},
            { new int[] {163, 253, 20}, 0.8},
            { new int[] {176, 254, 16}, 0.9},
            { new int[] {189, 255, 12}, 1.0},
            { new int[] {195, 254, 10}, 1.1},
            { new int[] {202, 254, 9}, 1.2},
            { new int[] {208, 254, 8}, 1.3},
            { new int[] {215, 254, 7}, 1.4},
            { new int[] {222, 255, 5}, 1.5},
            { new int[] {228, 254, 4}, 1.6},
            { new int[] {235, 255, 3}, 1.7},
            { new int[] {241, 254, 2}, 1.8},
            { new int[] {248, 255, 1}, 1.9},
            { new int[] {255, 255, 0}, 2.0},
            { new int[] {254, 251, 0}, 2.1},
            { new int[] {254, 248, 0}, 2.2},
            { new int[] {254, 244, 0}, 2.3},
            { new int[] {254, 241, 0}, 2.4},
            { new int[] {255, 238, 0}, 2.5},
            { new int[] {254, 234, 0}, 2.6},
            { new int[] {255, 231, 0}, 2.7},
            { new int[] {254, 227, 0}, 2.8},
            { new int[] {255, 224, 0}, 2.9},
            { new int[] {255, 221, 0}, 3.0},
            { new int[] {254, 213, 0}, 3.1},
            { new int[] {254, 205, 0}, 3.2},
            { new int[] {254, 197, 0}, 3.3},
            { new int[] {254, 190, 0}, 3.4},
            { new int[] {255, 182, 0}, 3.5},
            { new int[] {254, 174, 0}, 3.6},
            { new int[] {255, 167, 0}, 3.7},
            { new int[] {254, 159, 0}, 3.8},
            { new int[] {255, 151, 0}, 3.9},
            { new int[] {255, 144, 0}, 4.0},
            { new int[] {254, 136, 0}, 4.1},
            { new int[] {254, 128, 0}, 4.2},
            { new int[] {254, 121, 0}, 4.3},
            { new int[] {254, 113, 0}, 4.4},
            { new int[] {255, 106, 0}, 4.5},
            { new int[] {254, 98, 0}, 4.6},
            { new int[] {255, 90, 0}, 4.7},
            { new int[] {254, 83, 0}, 4.8},
            { new int[] {255, 75, 0}, 4.9},
            { new int[] {255, 68, 0}, 5.0},
            { new int[] {254, 61, 0}, 5.1},
            { new int[] {253, 54, 0}, 5.2},
            { new int[] {252, 47, 0}, 5.3},
            { new int[] {251, 40, 0}, 5.4},
            { new int[] {250, 33, 0}, 5.5},
            { new int[] {249, 27, 0}, 5.6},
            { new int[] {248, 20, 0}, 5.7},
            { new int[] {247, 13, 0}, 5.8},
            { new int[] {246, 6, 0}, 5.9},
            { new int[] {245, 0, 0}, 6.0},
            { new int[] {238, 0, 0}, 6.1},
            { new int[] {230, 0, 0}, 6.2},
            { new int[] {223, 0, 0}, 6.3},
            { new int[] {215, 0, 0}, 6.4},
            { new int[] {208, 0, 0}, 6.5},
            { new int[] {200, 0, 0}, 6.6},
            { new int[] {192, 0, 0}, 6.7},
            { new int[] {185, 0, 0}, 6.8},
            { new int[] {177, 0, 0}, 6.9},
            { new int[] {170, 0, 0}, 7.0}
        };

        /// <summary>
        /// Dictionaryでの配列比較に必要です。
        /// </summary>
        class ArrayEqualityComparer<T> : IEqualityComparer<T[]>
        {
            public bool Equals(T[] x, T[] y)
            {
                return StructuralComparisons.StructuralEqualityComparer.Equals(x, y);
            }

            public int GetHashCode(T[] obj)
            {
                return StructuralComparisons.StructuralEqualityComparer.GetHashCode(obj);
            }
        }
    }

}
