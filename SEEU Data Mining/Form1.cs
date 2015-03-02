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
            float[] notat = {10,10,5,5,4,3,2,5,6,7,7,8,9,7,4};
            DescriptiveStatistics ds = new DescriptiveStatistics(notat);

            MessageBox.Show("Minimumi :" + ds.Min().ToString());
            MessageBox.Show("Maximumi :" + ds.Max().ToString());
            MessageBox.Show("Devijimi :" + ds.StandardDeviation().ToString());

        }
    }
}
