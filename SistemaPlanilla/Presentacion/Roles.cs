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
    public partial class Roles : Form
    {
        public Roles()
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

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            DetalleEmpleado frmT = new DetalleEmpleado();
            frmT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexiones.conectar();
            string insertar = "INSERT INTO TBL_ROL (ACCESO_ROL)VALUES(@ACCESO_ROL)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexiones.conectar());
            cmd1.Parameters.AddWithValue("@ACCESO_ROL", textBox1.Text);
            

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron agregados con exito");


            dataGridView1.DataSource = llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexiones.conectar();
            string actualizar = "UPDATE TBL_ROL SET ACCESO_ROL=@ACCESO_ROL WHERE ID_ROL=@ID_ROL";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexiones.conectar());

            cmd2.Parameters.AddWithValue("@ACCESO_ROL", textBox1.Text);
            cmd2.Parameters.AddWithValue("@ID_ROL", textBox2.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexiones.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TBL_ROL";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexiones.conectar();
            string eliminar = "DELETE FROM TBL_ROL WHERE ID_ROL = @ID_ROL";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexiones.conectar());
            cmd3.Parameters.AddWithValue("@ID_ROL", textBox3.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados exitosamente");

            dataGridView1.DataSource = llenar_grid();
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
