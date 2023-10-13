using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioForm
{
    public partial class Clase_13_06_2022 : Form
    {
        public Clase_13_06_2022()
        {
            InitializeComponent();
        }

        private void crearArchivo_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamWriter arch = new StreamWriter("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\Ejemplo.txt");
                arch.WriteLine(textBox1.Text);
                /*while (textBox1 != null)
                {
                    textBox1 = null;
                    arch.WriteLine();
                    arch.WriteLine(textBox1.Text);
                }*/
                arch.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnmostrarlinea_Click(object sender, EventArgs e)
        {
            String linea;
            int c = 1;
            try
            {
                StreamReader arch = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\Ejemplo.txt");
                linea = arch.ReadLine();
                while(linea != null)
                {
                    MessageBox.Show(linea,"Linea"+c.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);
                    c++;
                    linea = arch.ReadLine();
                }
                
                arch.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
