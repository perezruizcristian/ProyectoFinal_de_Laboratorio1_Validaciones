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
    public partial class InicioLog : Form
    {
        public InicioLog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Form Registrar = new NuevoEmpleado();
            Registrar.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txbUsuario.Text))
            {
                MessageBox.Show("Deve ingresar su Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(txbContraseña.Text))
                {
                    MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    

                    string lineaUsuario;
                    string lineaContraseña;
                    try
                    { 
                        StreamReader archUsuario = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\Usuarios.txt");
                        lineaUsuario = archUsuario.ReadLine();
                        StreamReader archContraseña = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\Contraseña.txt");
                        lineaContraseña = archContraseña.ReadLine();
                        while (lineaUsuario != null)
                        { 
                            if ((lineaUsuario == txbUsuario.Text) && (lineaContraseña == txbContraseña.Text))
                            {
                                Form Acceso = new PantallaPrincipal();
                                Acceso.Show();
                                break;
                            }
                            lineaUsuario = archUsuario.ReadLine();
                            if (lineaUsuario == null)
                            {
                                MessageBox.Show("El Usuario y la Contraseña no Coinciden", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        archUsuario.Close();
                        archContraseña.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (txbContraseña.PasswordChar == '*')
            {
                txbContraseña.PasswordChar = '\0';
            }
            else
            {
                txbContraseña.PasswordChar = '*';
            }
            txbContraseña.Focus();
           
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
