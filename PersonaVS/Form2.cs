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
        private static System.IO.Stream str = Properties.Resources.sound;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);


        public Form2()
        {           
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form1 auxForm1 = new Form1();
           

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
            } else if (isDNIRepetido(dni))
            {
                player.Play();
                lblAdvertencia.Text = "El dni introducido ya existe en la base de datos";
            }
            else
            {
                string[] nomSplit = txtNombre.Text.Trim().Split(' ');
                nom = "";
                foreach (string str in nomSplit)
                {

                    String newStr = "";
                    
                    newStr = str.ToUpper().Substring(0, 1) + str.ToLower().Substring(1, str.Length - 1);
                    

                    nom += newStr + " ";
                }
                //nom = txtNombre.Text.Trim().ToUpper().Substring(0, 1) + txtNombre.Text.Trim().ToLower().Substring(1, txtNombre.Text.Trim().Length - 1);

                /*char[] chNombre = nom.ToCharArray();
                
                for (int i = 0; i < chNombre.Length; i++)
                {
                    if (i == 0) { nom = chNombre[i].ToString().ToUpper(); 
                    } else { nom += chNombre[i].ToString().ToLower(); }
                }*/
                

                string[] ape1Split = txtApellido1.Text.Trim().Split(' ');
                ape1 = "";
                foreach (string str in ape1Split) {
                    
                    String newStr = "";
                    if (str.ToLower().Equals("del") || str.ToLower().Equals("de") || str.ToLower().Equals("la"))
                    {
                        newStr = str.ToLower();
                        
                    } else
                    {
                        newStr = str.ToUpper().Substring(0, 1) + str.ToLower().Substring(1, str.Length - 1);
                    }

                    ape1 += newStr + " ";
                }


                //ape1 = txtApellido1.Text.Trim().ToUpper().Substring(0, 1) + txtApellido1.Text.Trim().ToLower().Substring(1, txtApellido1.Text.Trim().Length - 1);

                /*char[] chApe1 = ape1.ToCharArray();

                for (int i = 0; i < chApe1.Length; i++)
                {
                    if (i == 0)
                    {
                        ape1 = chApe1[i].ToString().ToUpper();
                    }
                    else { ape1 += chApe1[i].ToString().ToLower(); }
                }*/
                string[] ape2Split = txtApellido2.Text.Trim().Split(' ');
                ape2 = "";
                foreach (string str in ape2Split)
                {

                    String newStr = "";
                    if (str.ToLower().Equals("del") || str.ToLower().Equals("de") || str.ToLower().Equals("la"))
                    {
                        newStr = str.ToLower();

                    }
                    else
                    {
                        newStr = str.ToUpper().Substring(0, 1) + str.ToLower().Substring(1, str.Length - 1);
                    }

                    ape2 += newStr + " ";
                }
                //ape2 = txtApellido2.Text.Trim().ToUpper().Substring(0, 1) + txtApellido2.Text.Trim().ToLower().Substring(1, txtApellido2.Text.Trim().Length - 1);

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

                //int id = (Int32.Parse(auxForm1.dataGridView1.Rows[auxForm1.dataGridView1.Rows.Count].Cells[4].Value.ToString())) + 1;
                int id = Int32.Parse(Form1.dtPersonas.Tables[0].Rows[Form1.dtPersonas.Tables[0].Rows.Count - 1][4].ToString()) + 1;


                Form1.dtPersonas.Tables[0].Rows.Add(nom, ape1, ape2, dni, id);


                //Form1.dtPersonas.AcceptChanges();


                this.Hide();

                

                /*if (aux.introducirDatos(nom.Trim(), ape1.Trim(), ape2.Trim(), dni))
                {
                    this.Hide();

                    auxForm1.refrescar();

                }*/

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

        public Boolean isDNIRepetido(String dni)
        {
            

            Boolean isRepetido = false;

            String dniComp = "";

            int contFilas = Form1.dtPersonas.Tables[0].Rows.Count; 

            for (int i = 0; i < contFilas; i++)
            {
                //.Tables[0].Cells[3].Value.ToString()

                dniComp = Form1.dtPersonas.Tables[0].Rows[i][3].ToString();
                if(dni.Equals(dniComp))
                {
                    isRepetido = true;
                }
            }

            return isRepetido;
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
