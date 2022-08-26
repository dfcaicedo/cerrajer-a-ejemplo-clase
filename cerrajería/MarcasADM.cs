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
    public partial class MarcasADM : Form
    {
        public MarcasADM()
        {
            InitializeComponent();
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void MarcasADM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.database1DataSet.Marcas);

        }
    }
}
