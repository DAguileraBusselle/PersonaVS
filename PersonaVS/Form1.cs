using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public static DataSet dtPersonas;
        public SqlDataAdapter adapter;

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

            var connection = new SqlConnection("server=DESKTOP-0INU1AT;database=PersonasVS;integrated security=true;");
            
            string queryString = "SELECT * FROM PERSONAS";
            var cmd = new SqlCommand(queryString, connection) { CommandType = CommandType.Text };
            adapter = new SqlDataAdapter(queryString, connection);
            var comBuilder = new SqlCommandBuilder(adapter);

            

            dtPersonas = new DataSet();
            adapter.Fill(dtPersonas, "PERSONAS");
            


            dataGridView1.DataSource = dtPersonas.Tables[0];

            dataGridView1.Columns[0].Width = (dataGridView1.Width - 74) / 4;
            dataGridView1.Columns[1].Width = (dataGridView1.Width - 74) / 4;
            dataGridView1.Columns[2].Width = (dataGridView1.Width - 74) / 4;
            dataGridView1.Columns[3].Width = (dataGridView1.Width - 74) / 4;
            dataGridView1.Columns[4].Width = 55;

            
            
           

        }


        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
           
            player.Play();
            var res = MessageBox.Show("¿Quieres eliminar este usuario?", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            int fila = dataGridView1.CurrentRow.Index;

            if (res == DialogResult.Yes)
            {
                dtPersonas.Tables[0].Rows[fila].Delete();                
            }
        }



        

        private void btnModif_Click(object sender, EventArgs e)
        {
            FormModif formM = new FormModif();
           
            
            
            nombre = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ape1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ape2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dni = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());

            


            formM.Show();

            formM.setTxtsModif(nombre, ape1, ape2, dni);

            



        }
       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


            var cs = "Server=DESKTOP-0INU1AT;Database=PersonasVS;Integrated Security=true;";
            var cnn = new SqlConnection(cs);
            var cmd = new SqlCommand("select * from PERSONAS", cnn) { CommandType = CommandType.Text };
            var sa = new SqlDataAdapter(cmd) { UpdateBatchSize = 3 };
            var scb = new SqlCommandBuilder(sa);




            sa.Update(dtPersonas, "PERSONAS");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
            var cs = "Server=DESKTOP-0INU1AT;Database=PersonasVS;Integrated Security=true;";
            var cnn = new SqlConnection(cs);
            var cmd = new SqlCommand("select * from PERSONAS", cnn) { CommandType = CommandType.Text };
            var sa = new SqlDataAdapter(cmd) { UpdateBatchSize = 3 };
            var scb = new SqlCommandBuilder(sa);



            
            sa.Update(dtPersonas, "PERSONAS");
            dtPersonas.Clear();
            sa.Fill(dtPersonas, "PERSONAS");
            dataGridView1.DataSource = dtPersonas.Tables[0];
        }
    }
}
