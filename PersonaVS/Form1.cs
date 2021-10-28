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
        Form2 form2 = new Form2();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var aux = new Persistencia();
            aux.listar(dataGridView1);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var aux = new Persistencia();

            aux.filtrar(dataGridView1, this.textBox1.Text.Trim());
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
            this.Hide();
            form2.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var aux = new Persistencia();
            int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());

            var res = MessageBox.Show("¿Quieres eliminar este usuario?", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                aux.eliminarDatos(id);
                
                aux.listar(dataGridView1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            var aux = new Persistencia();
            aux.listar(dataGridView1);
        }
    }
}
