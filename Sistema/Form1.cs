using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema
{
    public partial class frmRegistro : Form
    {
        int tipoUsuario;
        public frmRegistro()
        {
            InitializeComponent();
        }

        MySqlConnection bd = new MySqlConnection();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConPassword.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = txtTelefono.Text;
            usuario.Cedula = txtCedula.Text;
            usuario.Ciudad = txtCiudad.Text;
            usuario.Area = txtArea.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Documento = txtDocumento.Text;

            try
            {

                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
 

            txtNombre.Text = Session.nombre;

            tipoUsuario = Session.id_tipo;


            if (tipoUsuario == 2)
            {
                this.btnFecha.Visible = true;
                this.dateTimePicker1.Visible = false;

            }


        }

        private void txtDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Aerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Aerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Aerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Aerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {


        }



        private void btnFecha_Click_1(object sender, EventArgs e)
        {
            txtDireccion.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = txtNombre.Text + txtUsuario.Text + "@cidenet.com.co";
        }

        private void btnUSA_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = txtNombre.Text + txtUsuario.Text +  "@cidenet.com.us";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            String usuario = txtUsuario.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT usuario, telefono, nombre, area, ciudad, cedula, documento FROM usuarios WHERE usuario LIKE '" + usuario + "' LIMIT 1";
            MySqlConnection conexionBD = Conexion.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        txtUsuario.Text = reader.GetString(0);
                        txtTelefono.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtArea.Text = reader.GetString(3);
                        txtCiudad.Text = reader.GetString(4);
                        txtCedula.Text = reader.GetString(5);
                        txtDocumento.Text = reader.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string actualizar = "update set ciudad, telefono, nombre=" + txtTelefono + txtNombre + txtCiudad + "where uuario=" + txtUsuario;

            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Exito");
                dataGridView1.DataSource = bd.SelectDataTable("select * from usuario");



            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.getConexion();
            try
            {

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("select * from usuarios");

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception)
            {

                throw;
            }

            conexionBD.Close();
        }
    }
}
