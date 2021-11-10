using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WECPOFLogic;

namespace PersonaVS
{
    public partial class FormModif : Form
    {


        private static System.IO.Stream str = Properties.Resources.sound;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);


        public FormModif()
        {
            InitializeComponent();

        }

        

        public void setTxtsModif(String nombre, String ape1, String ape2, String dni)
        {
            txtNombreModif.Text = nombre;
            txtApe1Modif.Text = ape1;
            txtApe2Modif.Text = ape2;
            txtDniModif.Text = dni;
        }

        private void btnCancelModif_Click(object sender, EventArgs e)
        {
            

            this.Close();
            

        }

        private void btnGuardarModif_Click(object sender, EventArgs e)
        {
            lblAdvertencia.ResetText();
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            Persistencia per = new Persistencia();


            

            if (txtNombreModif.Text.Length == 0 || txtApe1Modif.Text.Length == 0 || txtApe2Modif.Text.Length == 0 ||txtDniModif.Text.Length == 0)
            {
                player.Play();
                lblAdvertencia.Text ="Debe rellenar todos los campos";
            } else if (!form2.isDNIValido(txtDniModif.Text))
            {
                player.Play();
                lblAdvertencia.Text ="Debe introducir un DNI válido (12345678A)";
            } else if (per.isDniRepetido(txtDniModif.Text) && !per.idIgualporDni(txtDniModif.Text, Form1.id))
            {
                player.Play();
                lblAdvertencia.Text = "El DNI introducido ya está ligado a otro registro";
            } else if (txtNombreModif.Text.Equals(Form1.nombre) && txtApe1Modif.Text.Equals(Form1.ape1) && txtApe2Modif.Text.Equals(Form1.ape2) && txtDniModif.Text.Equals(Form1.dni))
            {

                player.Play();
                var res = MessageBox.Show("No has realizado cambios a los datos del registro", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    form1.refrescar();
                    this.Hide();
                   
                }
            } else
            {

                
                String nom = txtNombreModif.Text.Trim().ToUpper().Substring(0, 1) + txtNombreModif.Text.Trim().ToLower().Substring(1, txtNombreModif.Text.Trim().Length - 1);


                /*char[] chNombre = nom.ToCharArray();

                for (int i = 0; i < chNombre.Length; i++)
                {
                    if (i == 0)
                    {
                        nom = chNombre[i].ToString().ToUpper();
                    }
                    else { nom += chNombre[i].ToString().ToLower(); }
                }*/

                

                
                String ape1 = txtApe1Modif.Text.Trim().ToUpper().Substring(0, 1) + txtApe1Modif.Text.Trim().ToLower().Substring(1, txtApe1Modif.Text.Trim().Length - 1);


                /*char[] chApe1 = ape1.ToCharArray();

                for (int i = 0; i < chApe1.Length; i++)
                {
                    if (i == 0)
                    {
                        ape1 = chApe1[i].ToString().ToUpper();
                    }
                    else { ape1 += chApe1[i].ToString().ToLower(); }
                }*/
                 

                String ape2 = txtApe2Modif.Text.Trim().ToUpper().Substring(0, 1) + txtApe2Modif.Text.Trim().ToLower().Substring(1, txtApe2Modif.Text.Trim().Length - 1);


                /*char[] chApe2 = ape2.ToCharArray();

                for (int i = 0; i < chApe2.Length; i++)
                {
                    if (i == 0)
                    {
                        ape2 = chApe2[i].ToString().ToUpper();
                    }
                    else { ape2 += chApe2[i].ToString().ToLower(); }
                }*/

                String dni = txtDniModif.Text.Trim().Substring(0, 8) + txtDniModif.Text.Trim().ToUpper().Substring(8, 1);


                Boolean modifGuardado = per.modificarDatos(nom, ape1, ape2, dni, Form1.id);
                
                this.Hide();
                
                form1.refrescar();


            }

        }

        private void txtNombreModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }

        private void txtApe1Modif_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }

        private void txtApe2Modif_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }
        }
    }
}
