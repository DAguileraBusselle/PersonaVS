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
            Persistencia pers = new Persistencia();
            pers.filtrar(dataGridView1, this.textBox1.Text.Trim());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (Char.IsNumber(caracter))
            {
                e.Handled = true;
            }

        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persistencia pers = new Persistencia();

            int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());

            var res = MessageBox.Show("¿Quieres eliminar este usuario?", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                pers.eliminarDatos(id);
                
                pers.listar(dataGridView1);
            }
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Persistencia pers = new Persistencia();

            pers.listar(dataGridView1);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            FormModif formM = new FormModif();

            nombre = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ape1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ape2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dni = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());

            this.Hide();
            formM.Show();

            formM.setTxtsModif(nombre, ape1, ape2, dni);
        }
    }
}
