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
    public partial class frmPrinciapl : Form
    {

        int tipoUsuario;


        public frmPrinciapl()
        {
            InitializeComponent();

            txtNombre.Text = Session.nombre;

            tipoUsuario = Session.id_tipo;


            if (tipoUsuario == 1)
            {
                this.subMenuRegistrar.Visible = true;
                this.sunMenuConsultarUsuarios.Visible = true;
            }
            else
            { 
                this.subMenuRegistrar.Visible = false; 
                this.menuConfiguración.Visible = false;
            }
        }

        private void subMenuRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true; 
        }

        private void frmPrinciapl_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();  
            frm.Visible = true;

            Session ss = new Session();
        }

        private void frmPrinciapl_Load(object sender, EventArgs e)
        {

        }

        private void sunMenuConsultarUsuarios_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Visible = true;
        }
    }
}
