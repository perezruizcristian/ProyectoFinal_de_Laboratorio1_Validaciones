namespace ProyectoFinal_de_Laboratorio1
{
    partial class NuevoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEmpleado));
            this.pnlSupNuevUsuario = new System.Windows.Forms.Panel();
            this.pictureBCierre = new System.Windows.Forms.PictureBox();
            this.pictureNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.lblNuevoEmpleado = new System.Windows.Forms.Label();
            this.pnlInfeNuevUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbDpto = new System.Windows.Forms.TextBox();
            this.txbPiso = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.MostrarLegajo = new System.Windows.Forms.Label();
            this.pnlSupNuevUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNuevoUsuario)).BeginInit();
            this.pnlInfeNuevUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSupNuevUsuario
            // 
            this.pnlSupNuevUsuario.BackColor = System.Drawing.Color.Silver;
            this.pnlSupNuevUsuario.Controls.Add(this.pictureBCierre);
            this.pnlSupNuevUsuario.Controls.Add(this.pictureNuevoUsuario);
            this.pnlSupNuevUsuario.Controls.Add(this.lblNuevoEmpleado);
            this.pnlSupNuevUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlSupNuevUsuario.Name = "pnlSupNuevUsuario";
            this.pnlSupNuevUsuario.Size = new System.Drawing.Size(445, 33);
            this.pnlSupNuevUsuario.TabIndex = 0;
            this.pnlSupNuevUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSupNuevUsuario_Paint);
            // 
            // pictureBCierre
            // 
            this.pictureBCierre.Image = ((System.Drawing.Image)(resources.GetObject("pictureBCierre.Image")));
            this.pictureBCierre.Location = new System.Drawing.Point(417, 3);
            this.pictureBCierre.Name = "pictureBCierre";
            this.pictureBCierre.Size = new System.Drawing.Size(25, 25);
            this.pictureBCierre.TabIndex = 3;
            this.pictureBCierre.TabStop = false;
            this.pictureBCierre.Click += new System.EventHandler(this.pictureBCierre_Click);
            // 
            // pictureNuevoUsuario
            // 
            this.pictureNuevoUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.pictureNuevoUsuario.ErrorImage = null;
            this.pictureNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureNuevoUsuario.Image")));
            this.pictureNuevoUsuario.InitialImage = null;
            this.pictureNuevoUsuario.Location = new System.Drawing.Point(3, 0);
            this.pictureNuevoUsuario.Name = "pictureNuevoUsuario";
            this.pictureNuevoUsuario.Size = new System.Drawing.Size(32, 32);
            this.pictureNuevoUsuario.TabIndex = 2;
            this.pictureNuevoUsuario.TabStop = false;
            this.pictureNuevoUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNuevoEmpleado
            // 
            this.lblNuevoEmpleado.AutoSize = true;
            this.lblNuevoEmpleado.Location = new System.Drawing.Point(37, 9);
            this.lblNuevoEmpleado.Name = "lblNuevoEmpleado";
            this.lblNuevoEmpleado.Size = new System.Drawing.Size(98, 15);
            this.lblNuevoEmpleado.TabIndex = 0;
            this.lblNuevoEmpleado.Text = "Nuevo Empleado";
            // 
            // pnlInfeNuevUsuario
            // 
            this.pnlInfeNuevUsuario.BackColor = System.Drawing.Color.Gray;
            this.pnlInfeNuevUsuario.Controls.Add(this.btnCancelar);
            this.pnlInfeNuevUsuario.Controls.Add(this.btnGuardar);
            this.pnlInfeNuevUsuario.Location = new System.Drawing.Point(0, 252);
            this.pnlInfeNuevUsuario.Name = "pnlInfeNuevUsuario";
            this.pnlInfeNuevUsuario.Size = new System.Drawing.Size(445, 50);
            this.pnlInfeNuevUsuario.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(274, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(95, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLegajo.Location = new System.Drawing.Point(12, 51);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 15);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(12, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(12, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDNI.Location = new System.Drawing.Point(12, 143);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCalle.Location = new System.Drawing.Point(12, 176);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 15);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle";
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecNac.Location = new System.Drawing.Point(178, 142);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(119, 15);
            this.lblFecNac.TabIndex = 7;
            this.lblFecNac.Text = "Facha de Nacimiento";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(72, 110);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(347, 23);
            this.txbNombre.TabIndex = 9;
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(72, 139);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(100, 23);
            this.txbDNI.TabIndex = 10;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(72, 79);
            this.txbApellido.MaxLength = 2000;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(347, 23);
            this.txbApellido.TabIndex = 11;
            this.txbApellido.TextChanged += new System.EventHandler(this.txbApellido_TextChanged);
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(72, 173);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(347, 23);
            this.txbCalle.TabIndex = 13;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDpto.Location = new System.Drawing.Point(303, 213);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(33, 15);
            this.lblDpto.TabIndex = 14;
            this.lblDpto.Text = "Dpto";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPiso.Location = new System.Drawing.Point(178, 213);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(29, 15);
            this.lblPiso.TabIndex = 15;
            this.lblPiso.Text = "Piso";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumero.Location = new System.Drawing.Point(72, 213);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero";
            // 
            // txbDpto
            // 
            this.txbDpto.Location = new System.Drawing.Point(345, 210);
            this.txbDpto.Name = "txbDpto";
            this.txbDpto.Size = new System.Drawing.Size(74, 23);
            this.txbDpto.TabIndex = 17;
            // 
            // txbPiso
            // 
            this.txbPiso.Location = new System.Drawing.Point(213, 210);
            this.txbPiso.Name = "txbPiso";
            this.txbPiso.Size = new System.Drawing.Size(84, 23);
            this.txbPiso.TabIndex = 18;
            this.txbPiso.TextChanged += new System.EventHandler(this.txbPiso_TextChanged);
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(129, 210);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(43, 23);
            this.txbNumero.TabIndex = 19;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalendario.Location = new System.Drawing.Point(303, 135);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(116, 32);
            this.btnCalendario.TabIndex = 21;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaNac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaNac.Location = new System.Drawing.Point(313, 144);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(65, 15);
            this.lblFechaNac.TabIndex = 22;
            this.lblFechaNac.Text = "19/06/2022";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // MostrarLegajo
            // 
            this.MostrarLegajo.AutoSize = true;
            this.MostrarLegajo.BackColor = System.Drawing.Color.White;
            this.MostrarLegajo.Location = new System.Drawing.Point(72, 51);
            this.MostrarLegajo.Name = "MostrarLegajo";
            this.MostrarLegajo.Size = new System.Drawing.Size(42, 15);
            this.MostrarLegajo.TabIndex = 23;
            this.MostrarLegajo.Text = "Legajo";
            this.MostrarLegajo.Click += new System.EventHandler(this.MostrarLegajo_Click);
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(445, 303);
            this.Controls.Add(this.MostrarLegajo);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbPiso);
            this.Controls.Add(this.txbDpto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblDpto);
            this.Controls.Add(this.txbCalle);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblFecNac);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.pnlInfeNuevUsuario);
            this.Controls.Add(this.pnlSupNuevUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NuevoEmpleado";
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            this.pnlSupNuevUsuario.ResumeLayout(false);
            this.pnlSupNuevUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNuevoUsuario)).EndInit();
            this.pnlInfeNuevUsuario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlSupNuevUsuario;
        private PictureBox pictureNuevoUsuario;
        private Label lblNuevoEmpleado;
        private Panel pnlInfeNuevUsuario;
        private PictureBox pictureBCierre;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblLegajo;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblCalle;
        private Label lblFecNac;
        private TextBox txbNombre;
        private TextBox txbDNI;
        private TextBox txbApellido;
        private TextBox txbCalle;
        private Label lblDpto;
        private Label lblPiso;
        private Label lblNumero;
        private TextBox txbDpto;
        private TextBox txbPiso;
        private TextBox txbNumero;
        private Button btnCalendario;
        public Label lblFechaNac;
        private Label MostrarLegajo;
    }
}