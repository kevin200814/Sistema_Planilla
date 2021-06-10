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
    public partial class DetalleEmpleado : Form
    {
        public DetalleEmpleado()
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
           
            

        }

        private void lblCargo_Click(object sender, EventArgs e)
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
            Horario frmT = new Horario();
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

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado objDetalle = new ControlDetalleEmpleado();

            try
            {
                objDetalle.Carnet = int.Parse(txtCarnet.Text);
                objDetalle.Bono = float.Parse(txtBono.Text);
                objDetalle.Permiso = float.Parse(txtPermiso.Text);
                objDetalle.Horas_extras = int.Parse(txtHoras.Text);
                objDetalle.Dias_extras = int.Parse(txtDias.Text);

                bool respuestaSQL = objDetalle.InsertarDetalle();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo Detalle de empleado fueron insertados correctamente");
                    txtCarnet.Text = "Numero Carnet";
                    txtBono.Text = "Bono Empleado";
                    txtPermiso.Text = "Permiso con goce de sueldo";
                    txtHoras.Text = "Horas extras";
                    txtDias.Text = "Dias extras";

                }
                else
                {
                    MessageBox.Show(objDetalle.Mensaje);
                }
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + objDetalle.Mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado objDetalle = new ControlDetalleEmpleado();
            try
            {
                objDetalle.id_detalle = int.Parse(txtDetalle.Text);
                objDetalle.Carnet = int.Parse(txtnumCarnet.Text);
                objDetalle.Bono = float.Parse(txtBonoo.Text);
                objDetalle.Permiso = float.Parse(txtPermisoS.Text);
                objDetalle.Horas_extras = int.Parse(txtHorasE.Text);
                objDetalle.Dias_extras = int.Parse(txtDiasE.Text);


                bool respuestaSQL = objDetalle.ActualizarDetalle();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo registro fueron Actualizados correctamente");
                    txtDetalle.Text = "id Detalle";
                    txtnumCarnet.Text = "Numero Carnet";
                    txtBonoo.Text = "Bono Empleado";
                    txtPermisoS.Text = "Permiso con goce de sueldo";
                    txtHorasE.Text = "Horas extras";
                    txtDiasE.Text = "Dias extras";

                }
                else
                {
                    MessageBox.Show(objDetalle.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + objDetalle.Mensaje);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado obj = new ControlDetalleEmpleado();
            try
            {
                if (string.IsNullOrEmpty(txtIdDetalle.Text ?? string.Empty))
                {
                    MessageBox.Show("¡Ingrese el ID por favor! :D");
                    return;
                }

                int id = int.Parse(txtIdDetalle.Text);
                DataSet Datos = obj.ConsultarDetalle(id);
                DataDetalle.DataSource = Datos.Tables["TablaConsultada"].DefaultView;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void txtVerTodos_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado obj = new ControlDetalleEmpleado();
            try
            {
                DataSet DatosDetalle = obj.ConsultarTodosDetalle();
                int numregistros = DatosDetalle.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No hay datos en la tabla");
                }
                else
                {
                    DataSet DatosD = obj.ConsultarTodosDetalle();
                    DataDetalle.DataSource = DatosD.Tables["TablaConsultada"].DefaultView;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado obj = new ControlDetalleEmpleado();
            try
            {
                DataSet DatosDetalle = obj.ConsultarDetalle(int.Parse(txtDetalle.Text));
                int numregistros = DatosDetalle.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existen datos");
                }
                else
                {   
                    txtDetalle.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["ID_DETALLE"].ToString();
                    txtnumCarnet.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["NUM_CARNET"].ToString();
                    txtBonoo.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["BONO_EMPLEADO"].ToString();
                    txtPermisoS.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["PERMISO_CON_SUELDO"].ToString();
                    txtHorasE.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["HORAS_EXTRAS"].ToString();
                    txtDiasE.Text = DatosDetalle.Tables["TablaConsultada"].Rows[0]["DIAS_EXTRAS"].ToString();


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControlDetalleEmpleado obj = new ControlDetalleEmpleado();
            try
            {
                if (string.IsNullOrEmpty(txtDetalle.Text ?? string.Empty))
                {
                    MessageBox.Show("Por favor ingrese un ID");
                }
                else
                {
                    int idCargo = int.Parse(txtDetalle.Text);
                    bool respuestaSQL = obj.EliminarDetalle(idCargo);
                    if (respuestaSQL == true)
                    {
                        MessageBox.Show("Los datos fueron eliminados correctamente");
                        txtDetalle.Text = "id Detalle";
                        txtCarnet.Text = "Numero Carnet";
                        txtBono.Text = "Bono Empleado";
                        txtPermiso.Text = "Permiso con goce de sueldo";
                        txtHoras.Text = "Horas extras";
                        txtDias.Text = "Dias extras";
                    }
                    else
                    {
                        MessageBox.Show(obj.Mensaje);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void cerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
