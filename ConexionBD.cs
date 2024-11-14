using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class ConexionBD
{
    private string connectionString;

    public ConexionBD()
    {
        // Obtenemos la cadena de conexión desde App.config
        connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }

    public MySqlConnection ObtenerConexion()
    {
        MySqlConnection conexion = new MySqlConnection(connectionString);
        try
        {
            conexion.Open();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        return conexion;
    }

    public void CerrarConexion(MySqlConnection conexion)
    {
        if (conexion != null && conexion.State == ConnectionState.Open)
        {
            conexion.Close();
        }
    }
}
