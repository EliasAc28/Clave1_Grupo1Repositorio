using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatDogVeterinaria
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string contraseña = PasswordManager.HashPassword(txtContraseña.Text);
            string tipoUsuario = cmbTipoUsuario.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Contraseña, TipoUsuario) " +
                           "VALUES (@Nombre, @Apellido, @Email, @Contraseña, @TipoUsuario)";

            using (MySqlConnection conexion = new ConexionBD().ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                try
                {
                    int resultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(resultado > 0 ? "Usuario agregado correctamente." : "Error al agregar usuario.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ingrese el email del usuario que desea modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido WHERE Email = @Email";

            using (MySqlConnection conexion = new ConexionBD().ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    int resultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(resultado > 0 ? "Usuario modificado correctamente." : "No se encontró un usuario con ese email.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ingrese el email del usuario que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM Usuarios WHERE Email = @Email";

            using (MySqlConnection conexion = new ConexionBD().ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    int resultado = cmd.ExecuteNonQuery();
                    MessageBox.Show(resultado > 0 ? "Usuario eliminado correctamente." : "No se encontró un usuario con ese email.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
