
namespace PersonaVS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSONASBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personasVSDataSet = new PersonaVS.PersonasVSDataSet();
            this.pERSONASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASTableAdapter1 = new PersonaVS.PersonasVSDataSetTableAdapters.PERSONASTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personasVSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personasVSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 8, 8, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // pERSONASBindingSource3
            // 
            this.pERSONASBindingSource3.DataMember = "PERSONAS";
            this.pERSONASBindingSource3.DataSource = this.personasVSDataSet;
            // 
            // personasVSDataSet
            // 
            this.personasVSDataSet.DataSetName = "PersonasVSDataSet";
            this.personasVSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONASBindingSource1
            // 
            this.pERSONASBindingSource1.DataMember = "PERSONAS";
            this.pERSONASBindingSource1.DataSource = this.personasVSDataSet;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            // 
            // pERSONASTableAdapter1
            // 
            this.pERSONASTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // personasVSDataSetBindingSource
            // 
            this.personasVSDataSetBindingSource.DataSource = this.personasVSDataSet;
            this.personasVSDataSetBindingSource.Position = 0;
            // 
            // pERSONASBindingSource2
            // 
            this.pERSONASBindingSource2.DataMember = "PERSONAS";
            this.pERSONASBindingSource2.DataSource = this.personasVSDataSet;
            // 
            // personasVSDataSetBindingSource1
            // 
            this.personasVSDataSetBindingSource1.DataSource = this.personasVSDataSet;
            this.personasVSDataSetBindingSource1.Position = 0;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(242, 47);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(112, 32);
            this.btnAniadir.TabIndex = 3;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(391, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 32);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(751, 87);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 20);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(524, 47);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(102, 31);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.BindingSource pERSONASBindingSource;

        private PersonasVSDataSet personasVSDataSet;
        private System.Windows.Forms.BindingSource pERSONASBindingSource1;
        private PersonasVSDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource personasVSDataSetBindingSource;
        private System.Windows.Forms.BindingSource pERSONASBindingSource2;
        private System.Windows.Forms.BindingSource pERSONASBindingSource3;
        private System.Windows.Forms.BindingSource personasVSDataSetBindingSource1;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModif;
    }
}

