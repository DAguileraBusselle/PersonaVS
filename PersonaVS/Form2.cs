﻿using System;
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
        private static System.IO.Stream str = Properties.Resources.sound;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);


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
                player.Play();
                lblAdvertencia.Text = "Debe rellenar todos los campos";
            } else if (!isDNIValido(dni))
            {
                player.Play();
                lblAdvertencia.Text = "Debe introducir un dni valido (12345678A)";
            } else if (aux.isDniRepetido(dni))
            {
                player.Play();
                lblAdvertencia.Text = "El dni introducido ya existe en la base de datos";
            }
            else
            {
                
                nom = txtNombre.Text.Trim().ToUpper().Substring(0, 1) + txtNombre.Text.Trim().ToLower().Substring(1, txtNombre.Text.Trim().Length - 1);

                /*char[] chNombre = nom.ToCharArray();
                
                for (int i = 0; i < chNombre.Length; i++)
                {
                    if (i == 0) { nom = chNombre[i].ToString().ToUpper(); 
                    } else { nom += chNombre[i].ToString().ToLower(); }
                }*/

                ape1 = txtApellido1.Text.Trim().ToUpper().Substring(0, 1) + txtApellido1.Text.Trim().ToLower().Substring(1, txtApellido1.Text.Trim().Length - 1);

                /*char[] chApe1 = ape1.ToCharArray();

                for (int i = 0; i < chApe1.Length; i++)
                {
                    if (i == 0)
                    {
                        ape1 = chApe1[i].ToString().ToUpper();
                    }
                    else { ape1 += chApe1[i].ToString().ToLower(); }
                }*/
               
                ape2 = txtApellido2.Text.Trim().ToUpper().Substring(0, 1) + txtApellido2.Text.Trim().ToLower().Substring(1, txtApellido2.Text.Trim().Length - 1);

                /*char[] chApe2 = ape2.ToCharArray();

                 for (int i = 0; i < chApe2.Length; i++)
                 {
                     if (i == 0)
                     {
                         ape2 = chApe2[i].ToString().ToUpper();
                     }
                     else { ape2 += chApe2[i].ToString().ToLower(); }
                 }*/

                dni = txtDni.Text.Trim().Substring(0, 8) + txtDni.Text.Trim().ToUpper().Substring(8, 1);


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
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
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
