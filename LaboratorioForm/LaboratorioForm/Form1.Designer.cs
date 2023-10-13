namespace LaboratorioForm
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
            this.tbx_numero1 = new System.Windows.Forms.Label();
            this.btn_suma = new System.Windows.Forms.Button();
            this.tbx_numero2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_numero1
            // 
            this.tbx_numero1.AutoSize = true;
            this.tbx_numero1.Location = new System.Drawing.Point(189, 117);
            this.tbx_numero1.Name = "tbx_numero1";
            this.tbx_numero1.Size = new System.Drawing.Size(109, 15);
            this.tbx_numero1.TabIndex = 0;
            this.tbx_numero1.Text = "Ingrese un Numero";
            this.tbx_numero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suma.ForeColor = System.Drawing.Color.Black;
            this.btn_suma.ImageKey = "(ninguna)";
            this.btn_suma.Location = new System.Drawing.Point(210, 189);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 1;
            this.btn_suma.Text = "suma";
            this.btn_suma.UseVisualStyleBackColor = false;
            this.btn_suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // tbx_numero2
            // 
            this.tbx_numero2.AutoSize = true;
            this.tbx_numero2.Location = new System.Drawing.Point(189, 160);
            this.tbx_numero2.Name = "tbx_numero2";
            this.tbx_numero2.Size = new System.Drawing.Size(109, 15);
            this.tbx_numero2.TabIndex = 2;
            this.tbx_numero2.Text = "Ingrese un Numero";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(316, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(316, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_resultado.Location = new System.Drawing.Point(388, 117);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(56, 15);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "resultado";
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.Color.Red;
            this.btn_resta.ImageKey = "(ninguna)";
            this.btn_resta.Location = new System.Drawing.Point(210, 232);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 1;
            this.btn_resta.Text = "resta";
            this.btn_resta.UseVisualStyleBackColor = false;
            this.btn_resta.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.multiplicacion.Location = new System.Drawing.Point(210, 276);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.multiplicacion.TabIndex = 1;
            this.multiplicacion.Text = "Multiplicacion";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.division.Location = new System.Drawing.Point(210, 324);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 1;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbx_numero2);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.tbx_numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tbx_numero1;
        private Button btn_suma;
        private Label tbx_numero2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_resultado;
        private Button btn_resta;
        private Button multiplicacion;
        private Button division;
    }
}