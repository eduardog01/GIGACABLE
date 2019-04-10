using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIGACABLE
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            busqueda llamada2 = new busqueda();
            llamada2.ShowDialog();
            if (llamada2.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
