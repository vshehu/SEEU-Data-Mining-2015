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
        StreamReader sr = new StreamReader("c:\\data\\sq_AL.dic");
        List<string> gjitheFjalet = new List<string>();
        public Form1()
        {
            InitializeComponent();
            while (sr.EndOfStream != true)
            {
                gjitheFjalet.Add(sr.ReadLine().ToLower());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (gjitheFjalet.Contains(txtFjala.Text.ToLower()))
            {
                MessageBox.Show("Fjala eshte shkruar mire");
            }
            else
            {
                Dictionary<string, int> rekomandimet = new Dictionary<string, int>();
 
                LevensteinDistance l = new LevensteinDistance();
                foreach (string fjala in gjitheFjalet)
                {
                    if (rekomandimet.ContainsKey(fjala) == false)
                        rekomandimet.Add(fjala, l.Kalkulo(txtFjala.Text.ToLower(), fjala));
                }

                foreach (KeyValuePair<string, int> fjala in rekomandimet.OrderBy(x => x.Value).Take(5))
                {
                    lstRekomandime.Items.Add(fjala.Key +" - " + fjala.Value.ToString());
                }


            }

           
        }
    }
}
