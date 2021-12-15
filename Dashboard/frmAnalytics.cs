using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        public static object Dashboard { get; internal set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCmTXYM0rY7VlVlNrOA-O63A");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/m_viper04");
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
