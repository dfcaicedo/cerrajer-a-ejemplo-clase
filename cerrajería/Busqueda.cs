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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.database1DataSet.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.database1DataSet.Table, "%" +codigoToolStripTextBox.Text + "%") ;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
