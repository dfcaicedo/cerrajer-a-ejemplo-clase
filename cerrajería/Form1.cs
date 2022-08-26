using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cerrajería
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcasADM marcasADM = new MarcasADM();
            marcasADM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Codigos frm = new Codigos();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Importar frm = new Importar();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Busqueda frm = new Busqueda();
            frm.Show();
        }
    }
}
