using SEEU_Data_Mining.Similarity;
using SEEU_Data_Mining.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEEU_Data_Mining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("c:\\data\\sq_AL.dic");

            List<string> gjitheFjalet = new List<string>();

            while (sr.EndOfStream != true)
            {
                gjitheFjalet.Add(sr.ReadLine().ToLower());
            }


            if (gjitheFjalet.Contains(txtFjala.Text.ToLower()))
            {
                MessageBox.Show("Fjala eshte shkruar mire");
            }
            else
            {
                 MessageBox.Show("Fjala eshte shkruar gabim");
            }
        }
    }
}
