using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2_GemiddeldeMDI
{
    public partial class Form2 : Form
    {
        List<double> reeks = new List<double>();
        double total;
        double gemiddelde;

       
        public Form2()
        {
            InitializeComponent();
        }

        private void btNieuwGetal_Click(object sender, EventArgs e)
        {
            using (Form3 derdeForm = new Form3())
            {
                if (derdeForm.ShowDialog() == DialogResult.OK)
                {
                    lbGetallen.Items.Add(derdeForm.Getal);
                    double waarde = double.Parse(derdeForm.Getal);
                    reeks.Add(waarde);

                    for (int i = 0; i < reeks.Count; i++)
                    {
                        total = total + reeks[i];
                    }
                    tbGemiddelde.Text = Math.Round((total / reeks.Count), 2).ToString();
                    total = 0;
                }
            }
        }
    }
}
