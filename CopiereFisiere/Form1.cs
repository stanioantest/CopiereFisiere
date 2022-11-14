using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CopiereFisiere
{
    public partial class Form1 : Form
    {
        public int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void GetSettings()
        {
            txt_sursafisiere.Text = Properties.Settings.Default.sursafisiere;
            txt_destinatiefisiere.Text = Properties.Settings.Default.destinatiefisiere;
        }
        public void SaveSettings()
        {
            Properties.Settings.Default.destinatiefisiere = txt_destinatiefisiere.Text;
            Properties.Settings.Default.sursafisiere = txt_sursafisiere.Text;
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            seconds = (Properties.Settings.Default.timprescanare)/1000; 
            timer1.Start();
        }

        private void btn_salvare_Click(object sender, EventArgs e)
        {

            SaveSettings();
            GetSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string destinatieFisiere = CreareDirector();
            string[] sursaFisiere = Directory.GetFiles(txt_sursafisiere.Text);

            foreach (var item in sursaFisiere)
            {
                string numeFisier = System.IO.Path.GetFileName(item);
                string destFisier = System.IO.Path.Combine(destinatieFisiere, numeFisier);
                if (File.Exists(item))
                {
                    File.Delete(destFisier);
                }

                System.IO.File.Move(item, destFisier);

            }
            
        }
        public int GetMonth()
        {
            int numarLuna = Int32.Parse(DateTime.Now.ToString("MM"));
            return numarLuna;
        }

        public int GetYear()
        {

            int numarAn = DateTime.Now.Year;
            return numarAn;
        }
        
        public string MonthYear()
        {
            return GetYear() + "-" + GetMonth();
        }

        public string CreareDirector()
        {
            string numeDirector = Properties.Settings.Default.destinatiefisiere+@"\" + MonthYear();
            if (!Directory.Exists(numeDirector))
            {
                Directory.CreateDirectory(numeDirector);
            }
            return numeDirector;
        }
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = seconds--.ToString()+" s.";
            if(seconds < 0)
            {
                seconds = 20;
            }
        }

       
    }
}
