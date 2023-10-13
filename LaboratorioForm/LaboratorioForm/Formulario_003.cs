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
    public partial class Form_003 : Form
    {
        public Form_003()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double v1 = 0.0;
            double v2 = 0.0;

            v1 = Convert.ToDouble(txtBxValor1.Text);
            v2 = Convert.ToDouble(txtBxValor2.Text);

            if (radioBSuma.Checked == true)
                r = v1 + v2;
            if (radioBResta.Checked == true)
                r = v1 - v2;
            if (radioBMultip.Checked == true)
                r = v1 * v2;
            if (radioBDiv.Checked == true)
                r = v1 / v2;


            if (radBNegro.Checked == true)//Fijarse clase 09/06/22 como cambiar de color en label
                
               



            lblRes.Text = r.ToString();


        }

        private void radBNegro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAzul.Checked == true)
                cBAzul.ForeColor = System.Drawing.Color.Blue;
            else
                cBAzul.ForeColor = System.Drawing.Color.Black;
          
        }
    }
}
