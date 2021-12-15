using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Net;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;



namespace Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\WindowsApps\\Microsoft.4297127D64EC6_1.0.104.0_x64__8wekyb3d8bbwe\\Minecraft.exe");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://difficult-knights.myspreadshop.de/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://difficult-knights.de/Update/DCKN-Launcher.png";
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("C:\\Program Files\\MultiMC\\MultiMC.exe");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
