namespace Presentacion
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.DetalleEmpleado = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnPlanillas = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.RoyalBlue;
            this.MenuVertical.Controls.Add(this.DetalleEmpleado);
            this.MenuVertical.Controls.Add(this.btnCargos);
            this.MenuVertical.Controls.Add(this.btnPlanillas);
            this.MenuVertical.Controls.Add(this.lblNombre);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.lblCargo);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.btnRoles);
            this.MenuVertical.Controls.Add(this.btnHorarios);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.cerrarSesion);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // DetalleEmpleado
            // 
            this.DetalleEmpleado.FlatAppearance.BorderSize = 0;
            this.DetalleEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DetalleEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleEmpleado.ForeColor = System.Drawing.Color.White;
            this.DetalleEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("DetalleEmpleado.Image")));
            this.DetalleEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetalleEmpleado.Location = new System.Drawing.Point(0, 532);
            this.DetalleEmpleado.Name = "DetalleEmpleado";
            this.DetalleEmpleado.Size = new System.Drawing.Size(250, 40);
            this.DetalleEmpleado.TabIndex = 53;
            this.DetalleEmpleado.Text = "Detalle Empleado";
            this.DetalleEmpleado.UseVisualStyleBackColor = true;
            this.DetalleEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargos.Image")));
            this.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.Location = new System.Drawing.Point(0, 486);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(250, 40);
            this.btnCargos.TabIndex = 52;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click_1);
            // 
            // btnPlanillas
            // 
            this.btnPlanillas.FlatAppearance.BorderSize = 0;
            this.btnPlanillas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanillas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanillas.ForeColor = System.Drawing.Color.White;
            this.btnPlanillas.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanillas.Image")));
            this.btnPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanillas.Location = new System.Drawing.Point(0, 293);
            this.btnPlanillas.Name = "btnPlanillas";
            this.btnPlanillas.Size = new System.Drawing.Size(250, 40);
            this.btnPlanillas.TabIndex = 44;
            this.btnPlanillas.Text = "Planillas";
            this.btnPlanillas.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(94, 166);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(94, 124);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(28, 17);
            this.lblCargo.TabIndex = 49;
            this.lblCargo.Text = "Rol";
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 440);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 40);
            this.btnReportes.TabIndex = 48;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 394);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(250, 40);
            this.btnRoles.TabIndex = 47;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Image = ((System.Drawing.Image)(resources.GetObject("btnHorarios.Image")));
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.Location = new System.Drawing.Point(0, 348);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(250, 40);
            this.btnHorarios.TabIndex = 46;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 247);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(250, 40);
            this.btnEmpleados.TabIndex = 45;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 201);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnUsuarios.TabIndex = 43;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.cerrarSesion.Location = new System.Drawing.Point(6, 583);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(241, 40);
            this.cerrarSesion.TabIndex = 42;
            this.cerrarSesion.Text = "Cerrar Sesion";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = global::Presentacion.Properties.Resources.usam;
            this.btnlogoInicio.Location = new System.Drawing.Point(25, 12);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(198, 98);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 41;
            this.btnlogoInicio.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 45);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(969, 5);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(995, 5);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(18, 18);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(995, 5);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1021, 5);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(8, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 605);
            this.panelContenedor.TabIndex = 2;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Button DetalleEmpleado;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnPlanillas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.PictureBox btnlogoInicio;
    }
}

