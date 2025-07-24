using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using Modelos.Conexion;


namespace Vistas.Formularios
{
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        private void txtCorreoUsuario_Enter(object sender, EventArgs e)
        {
            if(txtCorreoUsuario.Text == "ejemplo@gmail.com")
            {
                txtCorreoUsuario.Text = "";
                txtCorreoUsuario.ForeColor = Color.White;
            }
        }

        private void txtCorreoUsuario_Leave(object sender, EventArgs e)
        {
            if(txtCorreoUsuario.Text == "")
            {
                txtCorreoUsuario.Text = "ejemplo@gmail.com";
                txtCorreoUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bynConfirmarCredenciales_Click(object sender, EventArgs e)
        { 
            if(txtCorreoUsuario.Text != "ejemplo@gmail.com")
            {
                if (txtContraseña.Text != "Contraseña")
                {
                    Usuario usuario = new Usuario();
                    var LoginValido = Usuario.LoginUsuario(txtCorreoUsuario.Text, txtContraseña.Text);
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "       " + "Por favor ingrese una contraseña";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "      " + "Por favor ingrese un correo electronico";
                lblError.Visible = true;
            }
        }

        

    }
}
