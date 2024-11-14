using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Autores: Pablo Sánchez & Elias Acevedo
/// Fecha: 19/10/2024
/// Version: 1.0.0
/// </summary>

namespace CatDogVeterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Depuración: Mostrar los valores que se envían a la consulta
                    MessageBox.Show($"Email: {txtEmail.Text}, Contraseña: {txtContraseña.Text}");

                    // Consulta SQL para verificar el tipo de usuario
                    string query = "SELECT TipoUsuario FROM Usuarios WHERE Email = @Email AND Contraseña = @Contraseña";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                    // Ejecutar la consulta y obtener el valor de TipoUsuario
                    var tipoUsuario = cmd.ExecuteScalar();

                    // Depuración: Mostrar el valor devuelto por la consulta
                    MessageBox.Show($"TipoUsuario: {tipoUsuario}");

                    // Verificar si el resultado de la consulta es null
                    if (tipoUsuario == null)
                    {
                        MessageBox.Show("Credenciales incorrectas.");
                        return;
                    }

                    string tipo = tipoUsuario.ToString();
                    MessageBox.Show($"Bienvenido, {tipo}");

                    // Redirigir según el tipo de usuario
                    Form formularioDestino;
                    switch (tipo)
                    {
                        case "Administrador":
                            formularioDestino = new frmAdmin();
                            break;
                        case "Veterinario":
                            formularioDestino = new dtpFechaConsulta();
                            break;
                        case "Dueño":
                            formularioDestino = new frmDueño();
                            break;
                        default:
                            MessageBox.Show("Tipo de usuario no reconocido.");
                            return;
                    }

                    formularioDestino.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
