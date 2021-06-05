using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Logica.Usuarios ObjUser = new Logica.Usuarios();
            try
            {
                string user = txtUsuario.Text;
                string pass = txtContrasena.Text;
                DataSet DatosUsuario = ObjUser.Login(user, pass);
                string rol = DatosUsuario.Tables["TablaConsultada"].Rows[0]["ACCESO_ROL"].ToString();

                if (rol == "Administrador")
                {
                   MenuAdmin frmT = new MenuAdmin();
                    frmT.Show();
                    this.Hide();
                }
                else
                {
                    if (rol == "Empleado")
                    {
                        MenuEmpleado frm = new MenuEmpleado();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + ObjUser.Mensaje);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
