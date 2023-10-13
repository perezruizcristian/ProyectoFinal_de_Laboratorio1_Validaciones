namespace LaboratorioForm
{
    partial class Form_003
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxValor1 = new System.Windows.Forms.TextBox();
            this.txtBxValor2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.radioBDiv = new System.Windows.Forms.RadioButton();
            this.radioBMultip = new System.Windows.Forms.RadioButton();
            this.radioBResta = new System.Windows.Forms.RadioButton();
            this.radioBSuma = new System.Windows.Forms.RadioButton();
            this.lblRes = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.GroupBox();
            this.radBNegro = new System.Windows.Forms.RadioButton();
            this.radBAzul = new System.Windows.Forms.RadioButton();
            this.cBAzul = new System.Windows.Forms.CheckBox();
            this.cBRojo = new System.Windows.Forms.CheckBox();
            this.gBoxOperaciones.SuspendLayout();
            this.Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2";
            // 
            // txtBxValor1
            // 
            this.txtBxValor1.Location = new System.Drawing.Point(203, 96);
            this.txtBxValor1.Name = "txtBxValor1";
            this.txtBxValor1.Size = new System.Drawing.Size(100, 23);
            this.txtBxValor1.TabIndex = 2;
            this.txtBxValor1.Text = "0";
            this.txtBxValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxValor2
            // 
            this.txtBxValor2.Location = new System.Drawing.Point(203, 158);
            this.txtBxValor2.Name = "txtBxValor2";
            this.txtBxValor2.Size = new System.Drawing.Size(100, 23);
            this.txtBxValor2.TabIndex = 3;
            this.txtBxValor2.Text = "0";
            this.txtBxValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(464, 78);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gBoxOperaciones
            // 
            this.gBoxOperaciones.Controls.Add(this.radioBDiv);
            this.gBoxOperaciones.Controls.Add(this.radioBMultip);
            this.gBoxOperaciones.Controls.Add(this.radioBResta);
            this.gBoxOperaciones.Controls.Add(this.radioBSuma);
            this.gBoxOperaciones.Location = new System.Drawing.Point(129, 239);
            this.gBoxOperaciones.Name = "gBoxOperaciones";
            this.gBoxOperaciones.Size = new System.Drawing.Size(174, 142);
            this.gBoxOperaciones.TabIndex = 5;
            this.gBoxOperaciones.TabStop = false;
            this.gBoxOperaciones.Text = "Operaciones";
            // 
            // radioBDiv
            // 
            this.radioBDiv.AutoSize = true;
            this.radioBDiv.Location = new System.Drawing.Point(38, 109);
            this.radioBDiv.Name = "radioBDiv";
            this.radioBDiv.Size = new System.Drawing.Size(67, 19);
            this.radioBDiv.TabIndex = 3;
            this.radioBDiv.TabStop = true;
            this.radioBDiv.Text = "Division";
            this.radioBDiv.UseVisualStyleBackColor = true;
            // 
            // radioBMultip
            // 
            this.radioBMultip.AutoSize = true;
            this.radioBMultip.Location = new System.Drawing.Point(38, 84);
            this.radioBMultip.Name = "radioBMultip";
            this.radioBMultip.Size = new System.Drawing.Size(101, 19);
            this.radioBMultip.TabIndex = 2;
            this.radioBMultip.TabStop = true;
            this.radioBMultip.Text = "Multiplicacion";
            this.radioBMultip.UseVisualStyleBackColor = true;
            // 
            // radioBResta
            // 
            this.radioBResta.AutoSize = true;
            this.radioBResta.Location = new System.Drawing.Point(38, 59);
            this.radioBResta.Name = "radioBResta";
            this.radioBResta.Size = new System.Drawing.Size(53, 19);
            this.radioBResta.TabIndex = 1;
            this.radioBResta.TabStop = true;
            this.radioBResta.Text = "Resta";
            this.radioBResta.UseVisualStyleBackColor = true;
            // 
            // radioBSuma
            // 
            this.radioBSuma.AutoSize = true;
            this.radioBSuma.Checked = true;
            this.radioBSuma.Location = new System.Drawing.Point(38, 34);
            this.radioBSuma.Name = "radioBSuma";
            this.radioBSuma.Size = new System.Drawing.Size(55, 19);
            this.radioBSuma.TabIndex = 0;
            this.radioBSuma.TabStop = true;
            this.radioBSuma.Text = "Suma";
            this.radioBSuma.UseVisualStyleBackColor = true;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(454, 145);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(13, 15);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "0";
            // 
            // Color
            // 
            this.Color.Controls.Add(this.radBNegro);
            this.Color.Controls.Add(this.radBAzul);
            this.Color.Location = new System.Drawing.Point(391, 239);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(200, 142);
            this.Color.TabIndex = 7;
            this.Color.TabStop = false;
            this.Color.Text = "groupBox1";
            // 
            // radBNegro
            // 
            this.radBNegro.AutoSize = true;
            this.radBNegro.Checked = true;
            this.radBNegro.Location = new System.Drawing.Point(53, 84);
            this.radBNegro.Name = "radBNegro";
            this.radBNegro.Size = new System.Drawing.Size(58, 19);
            this.radBNegro.TabIndex = 1;
            this.radBNegro.TabStop = true;
            this.radBNegro.Text = "Negro";
            this.radBNegro.UseVisualStyleBackColor = true;
            this.radBNegro.CheckedChanged += new System.EventHandler(this.radBNegro_CheckedChanged);
            // 
            // radBAzul
            // 
            this.radBAzul.AutoSize = true;
            this.radBAzul.Location = new System.Drawing.Point(53, 34);
            this.radBAzul.Name = "radBAzul";
            this.radBAzul.Size = new System.Drawing.Size(48, 19);
            this.radBAzul.TabIndex = 0;
            this.radBAzul.Text = "Azul";
            this.radBAzul.UseVisualStyleBackColor = true;
            // 
            // cBAzul
            // 
            this.cBAzul.AutoSize = true;
            this.cBAzul.Location = new System.Drawing.Point(597, 138);
            this.cBAzul.Name = "cBAzul";
            this.cBAzul.Size = new System.Drawing.Size(49, 19);
            this.cBAzul.TabIndex = 2;
            this.cBAzul.Text = "Azul";
            this.cBAzul.UseVisualStyleBackColor = true;
            this.cBAzul.CheckedChanged += new System.EventHandler(this.cBAzul_CheckedChanged);
            // 
            // cBRojo
            // 
            this.cBRojo.AutoSize = true;
            this.cBRojo.Location = new System.Drawing.Point(597, 163);
            this.cBRojo.Name = "cBRojo";
            this.cBRojo.Size = new System.Drawing.Size(50, 19);
            this.cBRojo.TabIndex = 8;
            this.cBRojo.Text = "Rojo";
            this.cBRojo.UseVisualStyleBackColor = true;
            // 
            // Form_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBAzul);
            this.Controls.Add(this.cBRojo);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.gBoxOperaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBxValor2);
            this.Controls.Add(this.txtBxValor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_003";
            this.Text = "Formulario_003";
            this.gBoxOperaciones.ResumeLayout(false);
            this.gBoxOperaciones.PerformLayout();
            this.Color.ResumeLayout(false);
            this.Color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxValor1;
        private TextBox txtBxValor2;
        private Button btnCalcular;
        private GroupBox gBoxOperaciones;
        private RadioButton radioBDiv;
        private RadioButton radioBMultip;
        private RadioButton radioBResta;
        private RadioButton radioBSuma;
        private Label lblRes;
        private GroupBox Color;
        private RadioButton radBNegro;
        private RadioButton radBAzul;
        private CheckBox cBAzul;
        private CheckBox cBRojo;
    }
}