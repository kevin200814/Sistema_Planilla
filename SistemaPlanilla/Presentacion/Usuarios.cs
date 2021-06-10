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
using System.Data.SqlClient;




namespace Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
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
            /*lblNombre.Text = LoginUsuarioCache.nombre + ", "+ LoginUsuarioCache.apellido;
            lblCargo.Text = LoginUsuarioCache.cargo;
            lblcorreo.Text = LoginUsuarioCache.email;*/
            

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
            this.Close();
            Cargo frmT = new Cargo();
            frmT.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
            Empleados frmT = new Empleados();
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
            Conexiones.conectar();
            string insertar = "INSERT INTO TBL_USUARIO (NICK_USUARIO, CONTRASENA_USUARIO, ID_ROL)VALUES(@NICK_USUARIO,@CONTRASENA_USUARIO,@ID_ROL)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexiones.conectar());
            cmd1.Parameters.AddWithValue("@NICK_USUARIO", textBox2.Text);
            cmd1.Parameters.AddWithValue("@CONTRASENA_USUARIO", textBox3.Text);
            cmd1.Parameters.AddWithValue("@ID_ROL", textBox1.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron agregados con exito");


            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            catch
            {

            }
        }

        public DataTable llenar_grid()
        {
            Conexiones.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TBL_USUARIO";
            SqlCommand cmd = new SqlCommand(consulta, Conexiones.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;


        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            Conexiones.conectar();


            dataGridView1.DataSource = llenar_grid();
        }

        private void btnConsultarUnEmpleado_Click(object sender, EventArgs e)
        {
            Conexiones.conectar();
            string actualizar = "UPDATE TBL_USUARIO SET NICK_USUARIO=@NICK_USUARIO, CONTRASENA_USUARIO=@CONTRASENA_USUARIO, ID_ROL=@ID_ROL WHERE ID_USUARIO=@ID_USUARIO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexiones.conectar());

            cmd2.Parameters.AddWithValue("@NICK_USUARIO", textBox4.Text);
            cmd2.Parameters.AddWithValue("@CONTRASENA_USUARIO", textBox7.Text);
            cmd2.Parameters.AddWithValue("@ID_ROL", textBox6.Text);
            cmd2.Parameters.AddWithValue("@ID_USUARIO", textBox5.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Conexiones.conectar();
            string eliminar = "DELETE FROM TBL_USUARIO WHERE ID_USUARIO = @ID_USUARIO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexiones.conectar());
            cmd3.Parameters.AddWithValue("@ID_USUARIO", textBox8.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados exitosamente");

            dataGridView1.DataSource = llenar_grid();
        }
    }
}
