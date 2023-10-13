namespace Ejemplo002_Form
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lEmpleado = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lCostoHoras = new System.Windows.Forms.Label();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.textBoxCostoHoras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxImporteNeto = new System.Windows.Forms.TextBox();
            this.tbxImporteBruto = new System.Windows.Forms.TextBox();
            this.tbxDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(229, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de Pago de Horas Extras";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lEmpleado
            // 
            this.lEmpleado.AutoSize = true;
            this.lEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEmpleado.Location = new System.Drawing.Point(114, 112);
            this.lEmpleado.Name = "lEmpleado";
            this.lEmpleado.Size = new System.Drawing.Size(79, 21);
            this.lEmpleado.TabIndex = 1;
            this.lEmpleado.Text = "Empleado";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHoras.Location = new System.Drawing.Point(114, 155);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(44, 21);
            this.lHoras.TabIndex = 2;
            this.lHoras.Text = "Hora";
            // 
            // lCostoHoras
            // 
            this.lCostoHoras.AutoSize = true;
            this.lCostoHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCostoHoras.Location = new System.Drawing.Point(114, 202);
            this.lCostoHoras.Name = "lCostoHoras";
            this.lCostoHoras.Size = new System.Drawing.Size(95, 21);
            this.lCostoHoras.TabIndex = 3;
            this.lCostoHoras.Text = "Costo Horas";
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmpleado.Location = new System.Drawing.Point(305, 110);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(100, 25);
            this.textBoxEmpleado.TabIndex = 4;
            this.textBoxEmpleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHoras.Location = new System.Drawing.Point(305, 155);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(100, 25);
            this.textBoxHoras.TabIndex = 5;
            // 
            // textBoxCostoHoras
            // 
            this.textBoxCostoHoras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCostoHoras.Location = new System.Drawing.Point(305, 198);
            this.textBoxCostoHoras.Name = "textBoxCostoHoras";
            this.textBoxCostoHoras.Size = new System.Drawing.Size(100, 25);
            this.textBoxCostoHoras.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(480, 112);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 29);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(480, 172);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 29);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.tbxImporteNeto);
            this.groupBox1.Controls.Add(this.tbxImporteBruto);
            this.groupBox1.Controls.Add(this.tbxDescuento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(114, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadro Resumen";
            // 
            // tbxImporteNeto
            // 
            this.tbxImporteNeto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxImporteNeto.Location = new System.Drawing.Point(369, 87);
            this.tbxImporteNeto.Name = "tbxImporteNeto";
            this.tbxImporteNeto.ReadOnly = true;
            this.tbxImporteNeto.Size = new System.Drawing.Size(100, 25);
            this.tbxImporteNeto.TabIndex = 8;
            // 
            // tbxImporteBruto
            // 
            this.tbxImporteBruto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxImporteBruto.Location = new System.Drawing.Point(23, 87);
            this.tbxImporteBruto.Name = "tbxImporteBruto";
            this.tbxImporteBruto.ReadOnly = true;
            this.tbxImporteBruto.Size = new System.Drawing.Size(100, 25);
            this.tbxImporteBruto.TabIndex = 7;
            // 
            // tbxDescuento
            // 
            this.tbxDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescuento.Location = new System.Drawing.Point(191, 87);
            this.tbxDescuento.Name = "tbxDescuento";
            this.tbxDescuento.ReadOnly = true;
            this.tbxDescuento.Size = new System.Drawing.Size(100, 25);
            this.tbxDescuento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(366, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importe Neto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descuento Ley";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Importe Bruto";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(696, 311);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 52);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBoxCostoHoras);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.textBoxEmpleado);
            this.Controls.Add(this.lCostoHoras);
            this.Controls.Add(this.lHoras);
            this.Controls.Add(this.lEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Horas Extras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Label lEmpleado;
        private Label lHoras;
        private Label lCostoHoras;
        private TextBox textBoxEmpleado;
        private TextBox textBoxHoras;
        private TextBox textBoxCostoHoras;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private TextBox tbxImporteNeto;
        private TextBox tbxImporteBruto;
        private TextBox tbxDescuento;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Salir;
    }
}