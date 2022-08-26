using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace cerrajería
{
    public partial class Importar : Form
    {
        public Importar()
        {
            InitializeComponent();
        }

        private void Importar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.database1DataSet.Marcas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            try
            {
                SqlConnection cnt = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
                cnt.Open();
                StreamReader lector = new StreamReader(fileDialog.FileName);
                SqlCommand cmd = new SqlCommand("insert into [Table] (code,Descripcion,marcas_id) values (@code,@desc,@marca)",cnt);                
                while (!lector.EndOfStream)
                {
                    cmd.Parameters.Clear();                    
                    string[] linea = lector.ReadLine().Split(';');
                    cmd.Parameters.AddWithValue("@code", linea[0]);
                    cmd.Parameters.AddWithValue("@desc", linea[1]);
                    cmd.Parameters.AddWithValue("@marca", listBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
                cnt.Close();
                MessageBox.Show("Ya cargó");
            }
            catch (Exception p) { }
        }
    }
}
