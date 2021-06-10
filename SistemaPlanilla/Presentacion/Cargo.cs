using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;


namespace Presentacion
{
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
            CargarDataUsuario();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250 )
            {
                MenuVertical.Width = 70;
               
            }
            else
                MenuVertical.Width = 250;
               
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuarios frmT = new Usuarios();
            frmT.Show();
            //AbrirFormEnPanel(new Productos());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new InicioResumen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void CargarDataUsuario() {
           /* lblNombre.Text = LoginUsuarioCache.nombre + ", "+ LoginUsuarioCache.apellido;
            lblCargo.Text = LoginUsuarioCache.cargo;
            lblcorreo.Text = LoginUsuarioCache.email*/
            

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Empleados frmT = new Empleados();
            frmT.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuarios frmT = new Usuarios();
            frmT.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
            Empleados frmT = new Empleados();
            frmT.Show();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            this.Close();
            Horas frmT = new Horario();
            frmT.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.Close();
            Roles frmT = new Roles();
            frmT.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            this.Close();
            Cargo frmT = new Cargo();
            frmT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DetalleEmpleado frmT = new DetalleEmpleado();
            frmT.Show();
        }

        private void btnPlanillas_Click(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlCargo objCargo = new ControlCargo();
            try
            {
                objCargo.Nombre = txtCargo.Text;
                objCargo.Tipo_Pago = txtPago.Text;
                objCargo.Salario = float.Parse(txtSalario.Text);
                objCargo.Pagod = float.Parse(txtPagoDiurno.Text);
                objCargo.PagoN = float.Parse(txtPagoNocturno.Text);

                bool respuestaSQL = objCargo.InsertarCargo();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo cargo fueron insertados correctamente");
                    txtCargo.Text = "Nombre cargo";
                    txtPago.Text = "Tipo Pago";
                    txtSalario.Text = "Salario de cargo";
                    txtPagoDiurno.Text = "Pago diurno";
                    txtPagoNocturno.Text = "Pago nocturno";
                   
                }
                else
                {
                    MessageBox.Show(objCargo.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + objCargo.Mensaje);
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            ControlCargo obj = new ControlCargo();
            try
            {
                if (string.IsNullOrEmpty(txtIdCargo.Text ?? string.Empty))
                {
                    MessageBox.Show("¡Ingrese el ID por favor! :D");
                    return;
                }

                int id = int.Parse((txtIdCargo.Text));
                DataSet Datos = obj.ConsultarCargo(id);
                DataCargo.DataSource = Datos.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnVerCargos_Click(object sender, EventArgs e)
        {
            ControlCargo obj = new ControlCargo();
            try
            {
                DataSet Dato = obj.ConsultarTodosCargo();
                int numregistros = Dato.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No hay datos en la tabla");
                }
                else
                {
                    DataSet Datos = obj.ConsultarTodosCargo();
                    DataCargo.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }
    }
}
