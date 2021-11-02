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
            Form1 form1 = new Form1();

            this.Close();
            form1.Show();

        }

        private void btnGuardarModif_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            Persistencia per = new Persistencia();

            if (txtNombreModif.Text.Length == 0 || txtApe1Modif.Text.Length == 0 || txtApe2Modif.Text.Length == 0 ||txtDniModif.Text.Length == 0)
            {
                MessageBox.Show("Debe rellenar todos los campos");
            } else if (!form2.isDNIValido(txtDniModif.Text))
            {
                MessageBox.Show("Debe introducir un DNI válido (12345678A)");
            } else if (per.isDniRepetido(txtDniModif.Text) && !per.idIgualporDni(txtDniModif.Text, Form1.id))
            {
                MessageBox.Show("El DNI introducido ya está ligado a otro registro");
            } else if (txtNombreModif.Text.Equals(Form1.nombre) && txtApe1Modif.Text.Equals(Form1.ape1) && txtApe2Modif.Text.Equals(Form1.ape2) && txtDniModif.Text.Equals(Form1.dni))
            {
                

                var res = MessageBox.Show("No has realizado cambios a los datos del registro", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    this.Close();
                    form1.Show();
                }
            } else
            {
                Boolean modifGuardado = per.modificarDatos(txtNombreModif.Text.Trim(), txtApe1Modif.Text.Trim(), txtApe2Modif.Text.Trim(), txtDniModif.Text.Trim(), Form1.id);

                this.Close();
                form1.Show();
            }
            
        }
    }
}
