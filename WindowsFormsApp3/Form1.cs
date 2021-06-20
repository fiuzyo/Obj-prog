using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statistika();
        }


        public void statistika()
        {

            //broj procesa
            Process[] procesi = Process.GetProcesses();
            brojprocesaTB.Text = procesi.Length.ToString();

            //broj dretvi
            long ukupnaMemorija = 0;
            int brojDretvi = 0;
            Process najveci = procesi[0];

            foreach(Process p in procesi)
            {
                brojDretvi += p.Threads.Count;
                ukupnaMemorija += p.WorkingSet64;

                if (p.WorkingSet64 > najveci.WorkingSet64) najveci = p;
            }

            brojDretviTB.Text = brojDretvi.ToString();
            memorijaTB.Text = ((double)ukupnaMemorija / Math.Pow(10, 9)).ToString();
            procMemTB.Text = najveci.ProcessName;

        }

        private void pokreniBTN_Click(object sender, EventArgs e)
        {


            try
            {
                Process p = Process.Start(nazivTB.Text, argumentiTB.Text);
                statusTB.Text = "Proces " + p.Id + " uspjesno pokrenut";

            }
            catch(Exception greska)
            {
                statusTB.Text = greska.Message;
            }
            statistika();

        }

        private void zaustaviBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.GetProcessById(int.Parse(idTB.Text));
                p.Kill();
                statusTB.Text = "Proces " + p.Id + " uspjesno zaustavljen";
            }
            catch(Exception ex)
            {
                statusTB.Text = ex.Message;
            }

            statistika();
        }
    }
}
