namespace LaboratorioForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            double num1, num2, res ;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            res = num1 + num2;

            if (num1 != 0 || num2 !=0)
            {
                lbl_resultado.Text = "El Resultado de la suma es: " + res.ToString();
            }
            else
            {
                lbl_resultado.Text = "";
                MessageBox.Show("Error. Para realizar la suma debe ingresar al menos un valor mayor que 0", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, res;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            if (num1 != 0 || num2 != 0)
            {
                res = num1 - num2;
                lbl_resultado.Text = "El resultado de la resta es "+ res.ToString();
            }
            else
            {
                lbl_resultado.Text = "";
                MessageBox.Show("Para realizar la resta deve ingresar al menos un valor", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            double num1, num2, res;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            res = num1 * num2;

            if ( num1 != 0 || num2 != 0)
            {
                lbl_resultado.Text = "El Resultado de la multiplicacion es " + res.ToString();
            }
            else
            {
                lbl_resultado.Text = "";
                MessageBox.Show("Deve ingresar almenos un valor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void division_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            res = num1 / num2;

            if (num1 != 0 || num2 != 0)
            {
                lbl_resultado.Text = "El Resultado de la Division es " + res.ToString();
            }
            else
            {
                lbl_resultado.Text = "";
                MessageBox.Show("Deve ingresar almenos un valor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}