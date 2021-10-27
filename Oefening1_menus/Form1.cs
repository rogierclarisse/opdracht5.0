using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1_menus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        


        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tbInput.ForeColor = Color.Red;

        }
        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.ForeColor = Color.Green;

        }
        

        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.ForeColor = Color.Blue;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                tbInput.ForeColor = Color.Red;
                return true;
            }
            else if (keyData == (Keys.Control | Keys.G))
            {
                tbInput.ForeColor = Color.Green;
                return true;
            }
            else if (keyData == (Keys.Control | Keys.B))
            {
                tbInput.ForeColor = Color.Blue;
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                tbInput.Font = new Font("Segoe UI", 7);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                tbInput.Font = new Font("Segoe UI", 10);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.L))
            {
                tbInput.Font = new Font("Segoe UI", 13);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Blue;
        }


        private void smallCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 7); 
        }

        private void normalCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 10);
        }

        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 13);
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbInput.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbInput.ForeColor = Color.Green;

        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbInput.ForeColor = Color.Blue;

        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Red;

        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Green;

        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbInput.BackColor = Color.Blue;

        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 7);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 10);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInput.Font = new Font("Segoe UI", 13);
        }
    }
}
