using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace S_net_Viewer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void ValueChange(string dt, Dictionary<string, double> ranking)
        {
            TB_NumDatas.Text = dt + "\r\n--------------------\r\n" + string.Join("\r\n", ranking.Select(x => x.Key + "  " + x.Value.ToString("0.0")));
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
