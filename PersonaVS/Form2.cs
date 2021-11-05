using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVS
{
    public partial class Form2 : Form

    {
        
        
        public Form2()
        {           
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form1 auxForm1 = new Form1();
            Persistencia aux = new Persistencia();

            String nom = txtNombre.Text.Trim();
            String ape1 = txtApellido1.Text.Trim();
            String ape2 = txtApellido2.Text.Trim();
            String dni = txtDni.Text.Trim();

            if (txtNombre.Text.Length == 0 || txtApellido1.Text.Length == 0 || txtApellido2.Text.Length == 0)
            {
                lblAdvertencia.Text = "Debe rellenar todos los campos";
            } else if (!isDNIValido(dni))
            {
                lblAdvertencia.Text = "Debe introducir un dni valido";
            } else if (aux.isDniRepetido(dni))
            {
                lblAdvertencia.Text = "El dni introducido ya existe en la base de datos";
            }
            else
            {
                nom = txtNombre.Text.Trim();
                ape1 = txtApellido1.Text.Trim();
                ape2 = txtApellido2.Text.Trim();
                dni = txtDni.Text.Trim();

                if (aux.introducirDatos(nom, ape1, ape2, dni))
                {
                    this.Hide();

                    auxForm1.refrescar();

                }

            }
        }

        public Boolean isDNIValido(String dni)
        {
            Boolean isValido = true;

            if (dni.Length != 9)
            {
                isValido = false;
            } else
            {
                char char9 = dni[8];
                String letra9 = char9.ToString();

                if (!char.IsLetter(char9))
                {
                    isValido = false;
                } else
                {
                    if (!letra9.Equals(letra9.ToUpper()))
                    {
                        isValido = false;
                    }
                }

                for (int i = 7; i >= 0; i--)
                {
                    if (char.IsLetter(dni[i]))
                    {
                        isValido = false;
                    }
                }
            }


            return isValido;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (Char.IsNumber(caracter))
            {
                e.Handled = true;
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (Char.IsNumber(caracter))
            {
                e.Handled = true;
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (Char.IsNumber(caracter))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 auxForm1 = new Form1();

            txtNombre.ResetText();
            txtApellido1.ResetText();
            txtApellido2.ResetText();
            txtDni.ResetText();
            this.Hide();
            

        }

        

        

        
    }
}
