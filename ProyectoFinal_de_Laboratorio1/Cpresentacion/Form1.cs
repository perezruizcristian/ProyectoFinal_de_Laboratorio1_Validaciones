namespace ProyectoFinal_de_Laboratorio1
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();

            string UsPantallaPrincipal;
            string lineaUsuraiosCompletos;
            try 
            {
                StreamReader UsuarioPantallaPrin = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\NombreUsuarioPrimario.txt");
                UsPantallaPrincipal = UsuarioPantallaPrin.ReadLine();


                if (UsPantallaPrincipal == null)
                {
                    lblUsuarioPantallaPrincipal.Text = "Error";
                }
                else
                {
                    lblUsuarioPantallaPrincipal.Text = UsPantallaPrincipal;
                }

                
                UsuarioPantallaPrin.Close();
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNuevoEmpleadoPantallaPrincipal_Click(object sender, EventArgs e)
        {
            Form Registrar = new NuevoEmpleado();
            Registrar.Show();
        }

        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCierredeVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcualizar_Click(object sender, EventArgs e)
        {
            string linea;
            int largo, n;
            StreamReader gridEmpleados = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\Empleados\\EmpleadosBic.txt");
            linea = gridEmpleados.ReadLine();
            dgvEmpleados.Rows.Clear();
            while (linea != null)
            {
                n = dgvEmpleados.Rows.Add();
                largo = linea.Length;
                if (largo > 140)
                {
                    dgvEmpleados.Rows[n].Cells[0].Value = linea.Substring(0, 4);
                    dgvEmpleados.Rows[n].Cells[1].Value = linea.Substring(19, 10) + "  " + linea.Substring(39, 15);
                    dgvEmpleados.Rows[n].Cells[2].Value = linea.Substring(59, 8);
                    dgvEmpleados.Rows[n].Cells[3].Value = linea.Substring(79, 11);
                    dgvEmpleados.Rows[n].Cells[4].Value = linea.Substring(99, 20) + linea.Substring(119, 4) + linea.Substring(139, 7) + linea.Substring(159, 7);
                }
                else
                {
                    dgvEmpleados.Rows[n].Cells[0].Value = linea.Substring(0, 4);
                    dgvEmpleados.Rows[n].Cells[1].Value = linea.Substring(19, 6) + "  " + linea.Substring(39, 15);
                    dgvEmpleados.Rows[n].Cells[2].Value = linea.Substring(59, 8);
                    dgvEmpleados.Rows[n].Cells[3].Value = linea.Substring(79, 11);
                    dgvEmpleados.Rows[n].Cells[4].Value = linea.Substring(99, 20) + linea.Substring(119, 4);
                }


                linea = gridEmpleados.ReadLine();
            }

            gridEmpleados.Close();
        }

        private void lblUsuarioPantallaPrincipal_Click(object sender, EventArgs e)
        {
            
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
