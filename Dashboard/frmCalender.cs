using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.Net;
using System.Drawing.Drawing2D;

namespace Dashboard
{
    public partial class frmCalender : Form
    {

        DataTable pingTable = new DataTable();
        List<string> ipAddress = new List<string>();
        List<PictureBox> pictureboxList = new List<PictureBox>();
        private System.Timers.Timer timer;



        public frmCalender()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 10000; //Ping Intervall 10 Sekunden
            timer.Enabled = true;
            timer.Elapsed += timer_Elapsed;

        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();


        }

        private void FillPingTable()
        {
            pingTable.Columns.Add("ip", typeof(string));
            pingTable.Columns.Add("pictureBox", typeof(string));

            pingTable.Rows.Add();

            for (int i = 0; i < ipAddress.Count; i++)

            {
                pingTable.Rows.Add(ipAddress[i], pictureboxList[i]);
        }
        }
            


        private void frmCalender_Load(object sender, System.EventArgs e)
        {
            using(var reader = new StreamReader(@"C:\Users\Public\Documents\DCKN-Settings.yml")) //Datei mit den IP Adressen
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\n');

                    ipAddress.Add(values[0]);

                }

                for(int i = 1 ; i<= 5; i++)
                {
                    pictureboxList.Add((PictureBox)Controls.Find("PictureBox" + i, true)[0]);
                }
                FillPingTable();

                backgroundWorker1.RunWorkerAsync();

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            Parallel.For(0, ipAddress.Count(), (i, loopState) =>
             {
                 Ping ping = new Ping();
                 PingReply pingReply = ping.Send(ipAddress[i].ToString());
                 this.BeginInvoke((Action)delegate ()
             {

                 pictureboxList[i].SizeMode = PictureBoxSizeMode.Zoom;
                 pictureboxList[i].BackColor = (pingReply.Status == IPStatus.Success) ? Color.Green : Color.Red;


             });
 


             });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.SendToBack();
        }
    }
}
