using SEEU_Data_Mining.Similarity;
using SEEU_Data_Mining.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
            LevensteinDistance d = new LevensteinDistance();
            MessageBox.Show(d.Kalkulo("Visar", "test").ToString());
        }
    }
}
