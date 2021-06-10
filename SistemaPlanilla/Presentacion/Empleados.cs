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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            CargarDataUsuario();
            ComboboxUsuarios();
            ComboboxCargo();
            ComboboxHorario();
            ComboboxDetalle();
        }

        private void ComboboxUsuarios()
        {
            ControlEmpleado objUsuarios = new ControlEmpleado();
            DataSet DatosUsuarios = objUsuarios.ConsultarTodosUsuarios();
            idUsuario.DataSource = DatosUsuarios.Tables["TablaConsultada"];
            idUsuario.ValueMember = "ID_USUARIO";
            idUsuario.DisplayMember = "NICK_USUARIO";

            //Para actualizar
            idUsuario2.DataSource = DatosUsuarios.Tables["TablaConsultada"];
            idUsuario2.ValueMember = "ID_USUARIO";
            idUsuario2.DisplayMember = "NICK_USUARIO";
        }
        
        private void ComboboxCargo()
        {
            ControlEmpleado obj = new ControlEmpleado();
            DataSet DatosCargo = obj.ConsultarTodosCargos();
            idCargo.DataSource = DatosCargo.Tables["TablaConsultada"];
            idCargo.ValueMember = "ID_CARGO";
            idCargo.DisplayMember = "NOMBRE_CARGO";

            //Para actualizar
            idCargo2.DataSource = DatosCargo.Tables["TablaConsultada"];
            idCargo2.ValueMember = "ID_CARGO";
            idCargo2.DisplayMember = "NOMBRE_CARGO";
        }
        private void ComboboxHorario()
        {
            ControlHorario obj = new ControlHorario();
            DataSet Datos = obj.ConsultarTodosHorarios();
            idHorario.DataSource = Datos.Tables["TablaConsultada"];
            idHorario.ValueMember = "ID_HORARIO";
            idHorario.DisplayMember = "TIPO_HORARIO";

            //Para actualizar
            idHorario2.DataSource = Datos.Tables["TablaConsultada"];
            idHorario2.ValueMember = "ID_HORARIO";
            idHorario2.DisplayMember = "TIPO_HORARIO";
        }
        private void ComboboxDetalle()
        {
            ControlEmpleado obj = new ControlEmpleado();
            DataSet Datos = obj.ConsultarTodosDetalles();
            idDetalle.DataSource = Datos.Tables["TablaConsultada"];
            idDetalle.ValueMember = "ID_DETALLE";
            idDetalle.DisplayMember = "NUM_CARNET";

            //Para actualizar
            idDetalle2.DataSource = Datos.Tables["TablaConsultada"];
            idDetalle2.ValueMember = "ID_DETALLE";
            idDetalle2.DisplayMember = "NUM_CARNET";
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
            this.Close();
            Usuarios frmT = new Usuarios();
            frmT.Show();
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
          /*  lblNombre.Text = LoginUsuarioCache.nombre + ", "+ LoginUsuarioCache.apellido;
            lblCargo.Text = LoginUsuarioCache.cargo;
            lblcorreo.Text = LoginUsuarioCache.email;*/
            

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Cargo frmT = new Cargo();
            frmT.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            this.Close();
            Cargo frmT = new Cargo();
            frmT.Show();
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

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Usuarios frmT = new Usuarios();
            frmT.Show();
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
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

        private void btnCargos_Click_1(object sender, EventArgs e)
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

        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                obj.TIPO_HORARIO = txtTipoHorario.Text;
                obj.HORA_INICIO = txtInicio.Text;
                obj.HORA_FINAL = txtFinal.Text;

                bool respuestaSQL = obj.InsertarHorario();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo registro fueron insertados correctamente");
                    txtTipoHorario.Text = "Tipo de horario";
                    txtInicio.Text = "Hora de inicio";
                    txtFinal.Text = "Hora de final";

                }
                else
                {
                    MessageBox.Show(obj.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                DataSet DatosHorarios = obj.ConsultarTodosHorarios();
                int numregistros = DatosHorarios.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No hay datos en la tabla");
                }
                else
                {
                    DataSet DatosHorariosLis = obj.ConsultarTodosHorarios();
                    ListarHorarios.DataSource = DatosHorariosLis.Tables["TablaConsultada"].DefaultView;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnConsultarUno_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text ?? string.Empty))
                {
                    MessageBox.Show("¡Ingrese el ID por favor! :D");
                    return;
                }
                string idHorario = txtSearch.Text;
                DataSet DatosHorario = obj.ConsultarHorario(idHorario);
                ListarHorarios.DataSource = DatosHorario.Tables["TablaConsultada"].DefaultView;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnConsultarDatoHorario_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                DataSet DatosHorario = obj.ConsultarHorario(txtIDHorario.Text);
                int numregistros = DatosHorario.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existen datos");
                }
                else
                {
                    txtIDHorario.Text = DatosHorario.Tables["TablaConsultada"].Rows[0]["ID_HORARIO"].ToString();
                    txtTipo_horario.Text = DatosHorario.Tables["TablaConsultada"].Rows[0]["TIPO_HORARIO"].ToString();
                    txtInicio2.Text = DatosHorario.Tables["TablaConsultada"].Rows[0]["HORA_INICIO"].ToString();
                    txtFin2.Text = DatosHorario.Tables["TablaConsultada"].Rows[0]["HORA_FINAL"].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnActualizarHorario_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                obj.ID_HORARIO = int.Parse(txtIDHorario.Text);
                obj.TIPO_HORARIO = txtTipo_horario.Text;
                obj.HORA_INICIO = txtInicio2.Text;
                obj.HORA_FINAL = txtFin2.Text;

                bool respuestaSQL = obj.ActualizarHorario();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo registro fueron insertados correctamente");
                    txtTipoHorario.Text = "Tipo de horario";
                    txtInicio.Text = "Hora de inicio";
                    txtFinal.Text = "Hora de final";

                }
                else
                {
                    MessageBox.Show(obj.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            ControlHorario obj = new ControlHorario();
            try
            {
                if(string.IsNullOrEmpty(txtIDHorario.Text ?? string.Empty))
                {
                    MessageBox.Show("Debe de ingresar un ID");
                }
                else
                {
                    int idHorario = int.Parse(txtIDHorario.Text);
                    bool respuestaSQL = obj.EliminarHorario(idHorario);
                    if (respuestaSQL == true)
                    {
                        MessageBox.Show("Los datos fueron eliminados correctamente");
                        txtIDHorario.Text = "ID Horario";
                        txtTipoHorario.Text = "Tipo de horario";
                        txtInicio.Text = "Hora de inicio";
                        txtFinal.Text = "Hora de final";
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

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                obj.NUM_CARNET = int.Parse(txtNcarnet.Text);
                obj.NOMBRES_EMPLEADO = txtNombres.Text;
                obj.APELLIDOS_EMPLEADO = txtApellidos.Text;
                obj.EDAD_EMPLEADO = int.Parse(txtEdad.Text);
                obj.SEXO_EMPLEADO = txtSexo.SelectedItem.ToString();
                obj.ID_USUARIO = int.Parse(idUsuario.SelectedValue.ToString());
                obj.ID_CARGO = int.Parse(idCargo.SelectedValue.ToString());
                obj.ID_HORARIO = int.Parse(idHorario.SelectedValue.ToString());
                obj.ID_DETALLE = int.Parse(idDetalle.SelectedValue.ToString());

                bool respuestaSQL = obj.InsertarEmpleado();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo registro fueron insertados correctamente");
                    txtNcarnet.Text = "Número de carnet";
                    txtNombres.Text = "Nombres"; 
                    txtApellidos.Text = "Apellidos"; 
                    txtEdad.Text = "Edad";
                    idUsuario.Text = "Usuario"; 
                    idCargo.Text = "Cargo";
                    idHorario.Text = "Horario";
                    idDetalle.Text = "Detalle";
                }
                else
                {
                    MessageBox.Show(obj.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnVerTodosEmpleados_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                DataSet Dato = obj.ConsultarTodosEmpleados();
                int numregistros = Dato.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No hay datos en la tabla");
                }
                else
                {
                    DataSet Datos = obj.ConsultarTodosEmpleados();
                    EmpleadosList.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnConsultarUnEmpleado_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                if (string.IsNullOrEmpty(txtSeachEmpleado.Text ?? string.Empty))
                {
                    MessageBox.Show("¡Ingrese el ID por favor! :D");
                    return;
                }
                int idEmpleado = int.Parse(txtSeachEmpleado.Text);
                DataSet Datos = obj.ConsultarEmpleado(idEmpleado);
                EmpleadosList.DataSource = Datos.Tables["TablaConsultada"].DefaultView;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                DataSet Datos = obj.ConsultarEmpleado(int.Parse(txtIdEmpleado.Text));
                int numregistros = Datos.Tables["TablaConsultada"].Rows.Count;
                if (numregistros == 0)
                {
                    MessageBox.Show("No existen datos");
                }
                else
                {
                    txtIdEmpleado.Text = Datos.Tables["TablaConsultada"].Rows[0]["ID_EMPLEADO"].ToString();
                    txtNcarnet2.Text = Datos.Tables["TablaConsultada"].Rows[0]["NUM_CARNET"].ToString();
                    txtNombres2.Text = Datos.Tables["TablaConsultada"].Rows[0]["NOMBRES_EMPLEADO"].ToString();
                    txtApellidos2.Text = Datos.Tables["TablaConsultada"].Rows[0]["APELLIDOS_EMPLEADO"].ToString();
                    txtEdad2.Text = Datos.Tables["TablaConsultada"].Rows[0]["EDAD_EMPLEADO"].ToString();

                    idSexo2.SelectedItem = Datos.Tables["TablaConsultada"].Rows[0]["SEXO_EMPLEADO"].ToString();
                    idUsuario2.SelectedValue = Datos.Tables["TablaConsultada"].Rows[0]["ID_USUARIO"].ToString();
                    idCargo2.SelectedValue = Datos.Tables["TablaConsultada"].Rows[0]["ID_CARGO"].ToString();
                    idHorario2.SelectedValue = Datos.Tables["TablaConsultada"].Rows[0]["ID_HORARIO"].ToString();
                    idDetalle2.SelectedValue = Datos.Tables["TablaConsultada"].Rows[0]["ID_DETALLE"].ToString();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Fatality!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                obj.ID_EMPLEADO = int.Parse(txtIdEmpleado.Text);
                obj.NUM_CARNET = int.Parse(txtNcarnet2.Text);
                obj.NOMBRES_EMPLEADO = txtNombres2.Text;
                obj.APELLIDOS_EMPLEADO = txtApellidos2.Text;
                obj.EDAD_EMPLEADO = int.Parse(txtEdad2.Text);
                obj.SEXO_EMPLEADO = idSexo2.SelectedItem.ToString();
                obj.ID_USUARIO = int.Parse(idUsuario2.SelectedValue.ToString());
                obj.ID_CARGO = int.Parse(idCargo2.SelectedValue.ToString());
                obj.ID_HORARIO = int.Parse(idHorario2.SelectedValue.ToString());
                obj.ID_DETALLE = int.Parse(idDetalle2.SelectedValue.ToString());

                bool respuestaSQL = obj.ActualizarEmpleado();
                if (respuestaSQL == true)
                {
                    MessageBox.Show("Los datos del nuevo registro fueron insertados correctamente");
                    txtIdEmpleado.Text = "ID Empleado";
                    txtNcarnet.Text = "Número de carnet";
                    txtNombres.Text = "Nombres";
                    txtApellidos.Text = "Apellidos";
                    txtEdad.Text = "Edad";
                    idUsuario.Text = "Usuario";
                    idCargo.Text = "Cargo";
                    idHorario.Text = "Horario";
                    idDetalle.Text = "Detalle";

                }
                else
                {
                    MessageBox.Show(obj.Mensaje);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error!: " + Ex.Message + " " + obj.Mensaje);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            ControlEmpleado obj = new ControlEmpleado();
            try
            {
                if (string.IsNullOrEmpty(txtIdEmpleado.Text ?? string.Empty))
                {
                    MessageBox.Show("Debe de ingresar un ID");
                }
                else
                {
                    int idEmpleado = int.Parse(txtIdEmpleado.Text);
                    bool respuestaSQL = obj.EliminarEmpleado(idEmpleado);
                    if (respuestaSQL == true)
                    {
                        MessageBox.Show("Los datos fueron eliminados correctamente");
                        txtIdEmpleado.Text = "ID Empleado";
                        txtNcarnet.Text = "Número de carnet";
                        txtNombres.Text = "Nombres";
                        txtApellidos.Text = "Apellidos";
                        txtEdad.Text = "Edad";
                        idUsuario.Text = "Usuario";
                        idCargo.Text = "Cargo";
                        idHorario.Text = "Horario";
                        idDetalle.Text = "Detalle";
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

        private void txtSeachEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
