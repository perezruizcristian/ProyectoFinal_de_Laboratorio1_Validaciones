namespace LaboratorioForm
{
    partial class Clase_13_06_2022
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crearArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBMostrarLinea = new System.Windows.Forms.TextBox();
            this.btnmostrarlinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linea";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crearArchivo
            // 
            this.crearArchivo.Location = new System.Drawing.Point(536, 41);
            this.crearArchivo.Name = "crearArchivo";
            this.crearArchivo.Size = new System.Drawing.Size(111, 23);
            this.crearArchivo.TabIndex = 2;
            this.crearArchivo.Text = "Agregar Linea";
            this.crearArchivo.UseVisualStyleBackColor = true;
            this.crearArchivo.Click += new System.EventHandler(this.crearArchivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mostrar";
            // 
            // tBMostrarLinea
            // 
            this.tBMostrarLinea.Location = new System.Drawing.Point(200, 164);
            this.tBMostrarLinea.Name = "tBMostrarLinea";
            this.tBMostrarLinea.Size = new System.Drawing.Size(289, 23);
            this.tBMostrarLinea.TabIndex = 4;
            // 
            // btnmostrarlinea
            // 
            this.btnmostrarlinea.Location = new System.Drawing.Point(536, 167);
            this.btnmostrarlinea.Name = "btnmostrarlinea";
            this.btnmostrarlinea.Size = new System.Drawing.Size(105, 23);
            this.btnmostrarlinea.TabIndex = 5;
            this.btnmostrarlinea.Text = "Mostrar Linea";
            this.btnmostrarlinea.UseVisualStyleBackColor = true;
            this.btnmostrarlinea.Click += new System.EventHandler(this.btnmostrarlinea_Click);
            // 
            // Clase_13_06_2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrarlinea);
            this.Controls.Add(this.tBMostrarLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crearArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Clase_13_06_2022";
            this.Text = "Clase_13_06_2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button crearArchivo;
        private Label label2;
        private TextBox tBMostrarLinea;
        private Button btnmostrarlinea;
    }
}