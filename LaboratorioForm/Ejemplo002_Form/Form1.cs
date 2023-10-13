namespace Ejemplo002_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           lblTitulo.Text= lblTitulo.Text.ToUpper();
           lblTitulo.ForeColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(textBoxHoras.Text);
            double costo = Convert.ToDouble(textBoxCostoHoras.Text);
            double bruto = horas * costo;
            double descuento = bruto * 0.15;
            tbxImporteBruto.Text = (horas * costo).ToString("C");
            tbxDescuento.Text = descuento.ToString("C");
            tbxImporteNeto.Text = (bruto - descuento).ToString("C");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxEmpleado.Clear();
            textBoxHoras.Clear();
            textBoxCostoHoras.Clear();
            tbxDescuento.Clear();
            tbxImporteBruto.Clear();
            tbxImporteNeto.Clear();
            textBoxEmpleado.Focus();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas Seguro que quieres salir?", "Atencion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.DarkRed;
            lblTitulo.Font = new Font("Arial", 20);
        }
    }
}