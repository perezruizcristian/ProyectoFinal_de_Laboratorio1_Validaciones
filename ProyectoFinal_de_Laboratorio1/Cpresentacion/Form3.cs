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
    public partial class NuevoEmpleado : Form
    {
        
        public NuevoEmpleado()
        {
            InitializeComponent();

            int ProxLeg = 0;
            string ProxLegTx;
            string lineaLegajo;
            StreamReader archLegajo = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\Legajo.txt");
            lineaLegajo = archLegajo.ReadLine();
            MostrarLegajo.Text = lineaLegajo;
            archLegajo.Close();
            StreamWriter ProximoLegajo = new StreamWriter("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\Legajo.txt");
            ProxLeg = Convert.ToInt32(lineaLegajo);
            ProxLeg = ProxLeg + 1;
            ProxLegTx = Convert.ToString(ProxLeg);
            ProximoLegajo.WriteLine(ProxLegTx);
            ProximoLegajo.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBCierre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void txbFecNac_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Form SeleccionarDia = new FormCalendario();
            SeleccionarDia.Show();
        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {
            string Fecha;
            StreamReader FdN = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\archFecDeNac.txt");
            Fecha = FdN.ReadLine();
            FdN.Close();
            lblFechaNac.Text = Fecha;
        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            if (String.IsNullOrEmpty(txbApellido.Text))
            {
                MessageBox.Show("Debe ingresar su Apellido", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                   
                if (String.IsNullOrEmpty(txbNombre.Text))
                {
                    MessageBox.Show("Debe ingresar su Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (String.IsNullOrEmpty(txbCalle.Text))
                    {
                        MessageBox.Show("Debe ingresar su Domicilio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txbDNI.Text))
                        {
                            MessageBox.Show("Debe ingresar su DNI ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            int Dni;
                            Dni = Convert.ToInt32(txbDNI.Text);
                            if ((Dni > 10000000) && (Dni < 99999999))
                            {
                                if (String.IsNullOrEmpty(txbNumero.Text))
                                {
                                    MessageBox.Show("Debe ingresar su Numero de Domicilio ", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                }
                                else
                                {
                                    int numdecalle;
                                    numdecalle = Convert.ToInt32(txbNumero.Text);
                                    if ((numdecalle > 0) && (numdecalle < 9999))
                                    {
                                        if ((String.IsNullOrEmpty(txbPiso.Text)) && (String.IsNullOrEmpty(txbDpto.Text)))
                                        {
                                            try
                                            {
                                                string CrearUsuario;
                                                string LineaComparativa;
                                                string PruebaUsuario;
                                                StreamReader archUsuario = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\NombreUsuarioPrimario.txt");
                                                LineaComparativa = archUsuario.ReadLine();
                                                PruebaUsuario = txbNombre.Text.Substring(0, 1);
                                                CrearUsuario = PruebaUsuario + txbApellido.Text;
                                                while (LineaComparativa != null)
                                                {
                                                    if (CrearUsuario == LineaComparativa)
                                                    {
                                                        PruebaUsuario = txbNombre.Text.Substring(0, 2);
                                                        CrearUsuario = PruebaUsuario + txbApellido.Text;
                                                    }
                                                    LineaComparativa = archUsuario.ReadLine();
                                                }
                                                StreamWriter Usuarios = File.AppendText("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Carpeta de Guardado\\Usuarios.txt");
                                                Usuarios.WriteLine(CrearUsuario);
                                                MessageBox.Show($"Tu Usuario es ({CrearUsuario})", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Usuarios.Close();
                                                archUsuario.Close();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }

                                            try
                                            {
                                                StreamWriter NuevoEmpleadoBic =  File.AppendText("C:\\Users\\User\\Desktop\\Lab de Comp\\PrimerCuatrimestre\\Empleados\\EmpleadosBic.txt");

                                                NuevoEmpleadoBic.WriteLine();
                                                NuevoEmpleadoBic.Write(MostrarLegajo.Text.PadRight(19));
                                                NuevoEmpleadoBic.Write(txbApellido.Text.PadRight(20));
                                                NuevoEmpleadoBic.Write(txbNombre.Text.PadRight(20));
                                                NuevoEmpleadoBic.Write(txbDNI.Text.PadRight(20));
                                                NuevoEmpleadoBic.Write(lblFechaNac.Text.PadRight(20));
                                                NuevoEmpleadoBic.Write(txbCalle.Text.PadRight(20));
                                                NuevoEmpleadoBic.Write(txbNumero.Text.PadRight(20));
                                                NuevoEmpleadoBic.Close();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }

                                        }
                                        else
                                        {

                                            if (String.IsNullOrEmpty(txbPiso.Text))
                                            {
                                                MessageBox.Show("Debe ingresar el Piso si ingresa el Departamento ", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                
                                            }
                                            else
                                            {
                                                if (String.IsNullOrEmpty(txbDpto.Text))
                                                {
                                                    MessageBox.Show("Debe ingresar el Departamento si ingresa el Piso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                   
                                                }
                                                else
                                                {
                                                    try
                                                    {
                                                        string CrearUsuario;
                                                        string LineaComparativa;
                                                        string PruebaUsuario;
                                                        StreamReader archUsuario = new StreamReader("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\NombreUsuarioPrimario.txt");
                                                        LineaComparativa = archUsuario.ReadLine();
                                                        PruebaUsuario = txbNombre.Text.Substring(0, 1);
                                                        CrearUsuario = PruebaUsuario + txbApellido.Text;
                                                        while (LineaComparativa != null)
                                                        {
                                                            if (CrearUsuario == LineaComparativa)
                                                            {
                                                                PruebaUsuario = txbNombre.Text.Substring(0, 2);
                                                                CrearUsuario = PruebaUsuario + txbApellido.Text;
                                                            }
                                                            LineaComparativa = archUsuario.ReadLine();
                                                        }
                                                        StreamWriter Usuarios = File.AppendText("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\Usuarios.txt");
                                                        Usuarios.WriteLine(CrearUsuario);
                                                        MessageBox.Show($"Tu Usuario es ({CrearUsuario})", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        Usuarios.Close();
                                                        archUsuario.Close();
                                                        string Us;
                                                        StreamWriter NombreNuevoUs = File.AppendText("C:\\Users\\User\\Desktop\\Lab de Comp\\Carpeta de Guardado\\NombreUsuarioPrimario.txt");
                                                        Us = txbNombre + " " + txbApellido;
                                                        NombreNuevoUs.WriteLine(Us);
                                                        NombreNuevoUs.Close();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }

                                                    try
                                                    {
                                                        StreamWriter NuevoEmpleadoBic = File.AppendText("C:\\Users\\User\\Desktop\\Lab de Comp\\Empleados\\EmpleadosBic.txt");

                                                        NuevoEmpleadoBic.WriteLine();
                                                        NuevoEmpleadoBic.Write(MostrarLegajo.Text.PadRight(19));
                                                        NuevoEmpleadoBic.Write(txbApellido.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(txbNombre.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(txbDNI.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(lblFechaNac.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(txbCalle.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(txbNumero.Text.PadRight(20));
                                                        NuevoEmpleadoBic.Write(" Dpto " + txbDpto.Text.PadRight(14));
                                                        NuevoEmpleadoBic.Write(" Piso " + txbPiso.Text.PadRight(14));
                                                        NuevoEmpleadoBic.Close();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar un Numero Valido para su Doimicilio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar su DNI Correctamente", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            txbApellido.Text = "";
            txbNombre.Text = "";
            txbDNI.Text = "";
            txbCalle.Text = "";
            txbDpto.Text = "";
            txbPiso.Text = "";
            txbNumero.Text = "";
            
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbPiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txbLegajo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarLegajo_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlSupNuevUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}        
            
               