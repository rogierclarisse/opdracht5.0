using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Oefening3_Kleuren
{
    public partial class Rechthoek : Form
    {
       List<Button> verzameling = new List<Button>(); 




        public Rechthoek()
        {
            InitializeComponent();

        }

        private void voegRechthoekToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rechthoek form = new Rechthoek();   
           
            Button btn = new Button();
            btn.Size = new Size(form.Width, form.Height);
            btn.Text = "test knop";
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 15;
            btn.FlatAppearance.BorderColor = Color.Green;
            verzameling.Add(btn);
            this.Controls.Add(btn);

        }


    }
}
