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
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Text;
using System.Reflection;
using System.Deployment.Application;

namespace Dashboard
{
    public partial class frmSettings : Form
    {
        public frmSettings()

        {
            InitializeComponent();
            
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = Properties.Settings.Default.username;
            label10.Text = Properties.Settings.Default.label;
        }

        


        private void btnsettings_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/MViper04/");
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Pfad = @"C:\Users\Public\Documents";
            String Pfad_Sub = System.IO.Path.Combine(Pfad, "DCKN");

            String Dateiname = "DCKN-Settings.yml";
            string Pfad_Datei = Path.Combine(Pfad, Dateiname);
            File.Create(Pfad_Datei).Close();

            string[] lines = { "173.212.219.64", "173.212.219.64", "161.97.158.102", "161.97.158.102", "127.0.0.1" };
            File.WriteAllLines(Pfad_Datei, lines);

            Console.WriteLine("Einstellungen erfolgreich geladen, Weiter mit beliebiger Taste!");
            Console.Read();


        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://files.multimc.org/downloads/mmc-develop-win32.zip");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("C:\\Users\\Public\\Documents\\MultiMC.txt", textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.username = textBox2.Text;
            Properties.Settings.Default.label = label10.Text;
            Properties.Settings.Default.Save();

        }
    }
}


