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
    public partial class Form1 : Form
    {
        private static System.IO.Stream str = Properties.Resources.sound;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);

        public static int id = 0;
        public static String nombre = "";
        public static String ape1 = "";
        public static String ape2 = "";
        public static String dni = "";

        public Form1()
        {

            
            InitializeComponent();
            
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Persistencia pers = new Persistencia();
            pers.listar(dataGridView1);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            

            Persistencia pers = new Persistencia();
            pers.filtrar(dataGridView1, this.textBox1.Text.Trim());

            if (dataGridView1.RowCount <= 0)
            {
                lblAdvertencia.Text = "Debe seleccionar un registro para eliminar o modificar";
                btnEliminar.Enabled = false;
                btnModif.Enabled = false;

            }
            else
            {
                lblAdvertencia.Text = "";
                btnEliminar.Enabled = true;
                btnModif.Enabled = true;
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!Char.IsLetter(caracter) && !caracter.Equals('\b') && !caracter.Equals(' '))
            {
                e.Handled = true;
            }

        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persistencia pers = new Persistencia();
            
            int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            player.Play();
            var res = MessageBox.Show("¿Quieres eliminar este usuario?", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                pers.eliminarDatos(id);

                pers.listar(dataGridView1);

            }
        }



        

        private void btnModif_Click(object sender, EventArgs e)
        {
            FormModif formM = new FormModif();
            Persistencia pers = new Persistencia();
            
            
            nombre = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ape1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            ape2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dni = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            


            formM.Show();

            formM.setTxtsModif(nombre, ape1, ape2, dni);

            



        }

        public void refrescar()
        {
           
            Persistencia pers = new Persistencia();

            pers.listar(this.dataGridView1);

            textBox1.ResetText();

        }


        

        private void Form1_Activated(object sender, EventArgs e)
        {
            Persistencia pers = new Persistencia();

            pers.listar(this.dataGridView1);
            textBox1.ResetText();
        }



       
    }
}
