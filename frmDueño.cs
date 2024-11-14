using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CatDogVeterinaria
{
    public partial class frmDueño : Form
    {
        // Declara la conexión a la base de datos
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=catdogdb; uid=root; pwd=;");
        public frmDueño()
        {
            InitializeComponent();
        }

        private void btnGuardarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO dueños (nombre, apellido, telefono, direccion) VALUES (@nombre, @apellido, @telefono, @direccion)";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombreDueño.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellidoDueño.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefonoDueño.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccionDueño.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dueño guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                MostrarDueños();
            }
        }
        private void MostrarDueños()
        {
            string query = "SELECT * FROM dueños";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvDueños.DataSource = tabla;
        }

    }
}
