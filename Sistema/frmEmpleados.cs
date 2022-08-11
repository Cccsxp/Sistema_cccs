using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmEmpleados : Form
    {

        int tipoUsuario;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
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
            catch (Exception b)
            {
                MessageBox.Show(b.Message+b.StackTrace);
                throw;
            }
            conexionBD.Close();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.getConexion();

            try
            {
                conexionBD.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM usuarios ('" + txtFiltro.Text + "%')";
                cmd.ExecuteNonQuery();


                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message + c.StackTrace);
                throw;
            }

            conexionBD.Close();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

            tipoUsuario = Session.id_tipo;


            if (tipoUsuario == 2)
            {
                this.btnMostrar.Visible = false;
                this.txtFiltro.Visible = false;

            }


        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
        }
    }
}
