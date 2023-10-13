namespace ProyectoFinal_de_Laboratorio1
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioPantallaPrincipal = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCierredeVentana = new System.Windows.Forms.Button();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalirSistema = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnAcualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevoEmpleadoPantallaPrincipal = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoyNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecDeNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelSuperior.BackColor = System.Drawing.Color.DimGray;
            this.PanelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSuperior.Controls.Add(this.pictureBox2);
            this.PanelSuperior.Controls.Add(this.lblUsuarioPantallaPrincipal);
            this.PanelSuperior.Controls.Add(this.lblHome);
            this.PanelSuperior.Controls.Add(this.btnHome);
            this.PanelSuperior.Controls.Add(this.btnMaximizar);
            this.PanelSuperior.Controls.Add(this.button1);
            this.PanelSuperior.Controls.Add(this.btnCierredeVentana);
            this.PanelSuperior.Location = new System.Drawing.Point(145, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(654, 45);
            this.PanelSuperior.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(378, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuarioPantallaPrincipal
            // 
            this.lblUsuarioPantallaPrincipal.AutoSize = true;
            this.lblUsuarioPantallaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuarioPantallaPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioPantallaPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarioPantallaPrincipal.Location = new System.Drawing.Point(417, 12);
            this.lblUsuarioPantallaPrincipal.Name = "lblUsuarioPantallaPrincipal";
            this.lblUsuarioPantallaPrincipal.Size = new System.Drawing.Size(66, 23);
            this.lblUsuarioPantallaPrincipal.TabIndex = 7;
            this.lblUsuarioPantallaPrincipal.Text = "Usuario";
            this.lblUsuarioPantallaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuarioPantallaPrincipal.Click += new System.EventHandler(this.lblUsuarioPantallaPrincipal_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(46, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(41, 15);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "Home";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(8, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(32, 32);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(597, -1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(566, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCierredeVentana
            // 
            this.btnCierredeVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCierredeVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCierredeVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCierredeVentana.BackgroundImage")));
            this.btnCierredeVentana.FlatAppearance.BorderSize = 0;
            this.btnCierredeVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierredeVentana.Location = new System.Drawing.Point(628, -1);
            this.btnCierredeVentana.Name = "btnCierredeVentana";
            this.btnCierredeVentana.Size = new System.Drawing.Size(25, 25);
            this.btnCierredeVentana.TabIndex = 2;
            this.btnCierredeVentana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierredeVentana.UseVisualStyleBackColor = false;
            this.btnCierredeVentana.Click += new System.EventHandler(this.btnCierredeVentana_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIzquierdo.BackColor = System.Drawing.Color.Gray;
            this.panelIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIzquierdo.Controls.Add(this.btnEmpleados);
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 45);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(145, 373);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.DimGray;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.Image = global::ProyectoFinal_de_Laboratorio1.Properties.Resources.UsuariosImg;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(-1, -1);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(145, 42);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalirSistema
            // 
            this.btnSalirSistema.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSalirSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSistema.ForeColor = System.Drawing.Color.White;
            this.btnSalirSistema.Image = global::ProyectoFinal_de_Laboratorio1.Properties.Resources.ImgSalirSistema;
            this.btnSalirSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirSistema.Location = new System.Drawing.Point(0, 1);
            this.btnSalirSistema.Name = "btnSalirSistema";
            this.btnSalirSistema.Size = new System.Drawing.Size(145, 34);
            this.btnSalirSistema.TabIndex = 3;
            this.btnSalirSistema.Text = "Salir del Sistema";
            this.btnSalirSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirSistema.UseVisualStyleBackColor = false;
            this.btnSalirSistema.Click += new System.EventHandler(this.btnSalirSistema_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.DarkGray;
            this.panelInferior.Controls.Add(this.btnAcualizar);
            this.panelInferior.Controls.Add(this.btnSalirSistema);
            this.panelInferior.Location = new System.Drawing.Point(0, 417);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(799, 35);
            this.panelInferior.TabIndex = 3;
            // 
            // btnAcualizar
            // 
            this.btnAcualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcualizar.FlatAppearance.BorderSize = 3;
            this.btnAcualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAcualizar.Image")));
            this.btnAcualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcualizar.Location = new System.Drawing.Point(690, 0);
            this.btnAcualizar.Name = "btnAcualizar";
            this.btnAcualizar.Size = new System.Drawing.Size(109, 31);
            this.btnAcualizar.TabIndex = 4;
            this.btnAcualizar.Text = "Refresh List";
            this.btnAcualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcualizar.UseVisualStyleBackColor = true;
            this.btnAcualizar.Click += new System.EventHandler(this.btnAcualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txbBuscar);
            this.panel1.Controls.Add(this.btnNuevoEmpleadoPantallaPrincipal);
            this.panel1.Location = new System.Drawing.Point(145, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 42);
            this.panel1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(588, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(418, 11);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(164, 23);
            this.txbBuscar.TabIndex = 1;
            // 
            // btnNuevoEmpleadoPantallaPrincipal
            // 
            this.btnNuevoEmpleadoPantallaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleadoPantallaPrincipal.FlatAppearance.BorderSize = 3;
            this.btnNuevoEmpleadoPantallaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleadoPantallaPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleadoPantallaPrincipal.Image")));
            this.btnNuevoEmpleadoPantallaPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleadoPantallaPrincipal.Location = new System.Drawing.Point(9, 5);
            this.btnNuevoEmpleadoPantallaPrincipal.Name = "btnNuevoEmpleadoPantallaPrincipal";
            this.btnNuevoEmpleadoPantallaPrincipal.Size = new System.Drawing.Size(130, 33);
            this.btnNuevoEmpleadoPantallaPrincipal.TabIndex = 0;
            this.btnNuevoEmpleadoPantallaPrincipal.Text = "Nuevo Empleado";
            this.btnNuevoEmpleadoPantallaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleadoPantallaPrincipal.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleadoPantallaPrincipal.Click += new System.EventHandler(this.btnNuevoEmpleadoPantallaPrincipal_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.ApellidoyNombre,
            this.DNI,
            this.FecDeNac,
            this.Domicilio});
            this.dgvEmpleados.Location = new System.Drawing.Point(148, 89);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(651, 329);
            this.dgvEmpleados.TabIndex = 5;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 60;
            // 
            // ApellidoyNombre
            // 
            this.ApellidoyNombre.HeaderText = "Apellido y Nombre";
            this.ApellidoyNombre.Name = "ApellidoyNombre";
            this.ApellidoyNombre.ReadOnly = true;
            this.ApellidoyNombre.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // FecDeNac
            // 
            this.FecDeNac.HeaderText = "Fecha de Nac.";
            this.FecDeNac.Name = "FecDeNac";
            this.FecDeNac.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 197;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.PanelSuperior);
            this.Name = "PantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelSuperior;
        private Panel panelIzquierdo;
        private Button btnMaximizar;
        private Button button1;
        private Button btnCierredeVentana;
        private PictureBox pictureBox1;
        private Label lblHome;
        private Button btnHome;
        private Button btnEmpleados;
        private Button btnSalirSistema;
        private Panel panelInferior;
        private Panel panel1;
        private Button btnNuevoEmpleadoPantallaPrincipal;
        private DataGridView dgvEmpleados;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn ApellidoyNombre;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn FecDeNac;
        private DataGridViewTextBoxColumn Domicilio;
        private Button btnAcualizar;
        private PictureBox pictureBox2;
        private Label lblUsuarioPantallaPrincipal;
    }
}