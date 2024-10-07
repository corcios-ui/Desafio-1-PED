using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1
{
    public partial class LogIN : Form
    {
        Archivo Ingresar;

        public LogIN()
        {
            InitializeComponent();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-CEE9SSS\\SQLEXPRESS01;Initial Catalog=pacienteDB;Integrated Security=True");

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión a la base de datos establecida.");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }






        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del usuario
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            // Validar los datos (opcional)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario y contraseña.");
                return;
            }


            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-CEE9SSS\\SQLEXPRESS01;Initial Catalog=pacienteDB;Integrated Security=True");



            try
            {
                conexion.Open();

                // Consulta SQL con parámetros 
                string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario = @username AND Contrasena = @password";
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)

                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    // Redirigir a otro formulario
                    Ingresar = new Archivo();
                    Ingresar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }


        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

    }
 }
    
   

