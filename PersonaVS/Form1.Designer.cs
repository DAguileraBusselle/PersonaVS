
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasVSDataSet = new PersonaVS.PersonasVSDataSet();
            this.pERSONASTableAdapter1 = new PersonaVS.PersonasVSDataSetTableAdapters.PERSONASTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(9, 12, 12, 8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 559);
            this.dataGridView1.TabIndex = 0;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            this.pERSONASBindingSource.DataSource = this.personasVSDataSet;
            // 
            // personasVSDataSet
            // 
            this.personasVSDataSet.DataSetName = "PersonasVSDataSet";
            this.personasVSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONASTableAdapter1
            // 
            this.pERSONASTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAniadir
            // 
            this.btnAniadir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAniadir.Location = new System.Drawing.Point(18, 610);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(168, 49);
            this.btnAniadir.TabIndex = 3;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.Location = new System.Drawing.Point(352, 609);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 49);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModif.Location = new System.Drawing.Point(705, 609);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(153, 48);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdvertencia.Location = new System.Drawing.Point(238, 662);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(0, 20);
            this.lblAdvertencia.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1039, 610);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 48);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update db";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasVSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;

        private PersonasVSDataSet personasVSDataSet;
        private PersonasVSDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.BindingSource pERSONASBindingSource;
        private System.Windows.Forms.Button btnUpdate;
    }
}

