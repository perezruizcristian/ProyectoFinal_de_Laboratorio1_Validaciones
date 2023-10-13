using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_de_Laboratorio1
{
    public partial class FormCalendario : Form
    {
        public FormCalendario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            DateTime fechaN = monthCalendar1.SelectionStart;
            lblFecNac.Text = fechaN.ToString();

            try
            {
                StreamWriter archFecDeNac = new StreamWriter("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\archFecDeNac.txt");
                archFecDeNac.WriteLine(fechaN.ToString("d"));
                archFecDeNac.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lblFecNac_Click(object sender, EventArgs e)
        {

        }
    }
}
