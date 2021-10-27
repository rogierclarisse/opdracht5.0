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
    public partial class Form3 : Form
    {
        public string Getal{  get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //btOk.DialogResult = DialogResult.OK;
            Getal = tbWaarde.Text;
            
        }

       
    }
}
