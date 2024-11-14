using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CatDogVeterinaria
{
    public partial class dtpFechaConsulta : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=catdogdb; uid=root; pwd=Pablo07+02+1996;");
        public dtpFechaConsulta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {   

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO veterinarios (nombre, apellido, especialidad) VALUES (@nombre, @apellido, @especialidad)";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombreVeterinario.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellidoVeterinario.Text);
                comando.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Información guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                MostrarDatos();
            }

        }
        private void MostrarDatos()
        {
            string query = "SELECT * FROM veterinarios";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvConsultas.DataSource = tabla;
        }
        private void frmVeterinario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
