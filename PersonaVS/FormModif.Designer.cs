
namespace PersonaVS
{
    partial class FormModif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.txtNombreModif = new System.Windows.Forms.TextBox();
            this.txtApe1Modif = new System.Windows.Forms.TextBox();
            this.txtApe2Modif = new System.Windows.Forms.TextBox();
            this.txtDniModif = new System.Windows.Forms.TextBox();
            this.btnGuardarModif = new System.Windows.Forms.Button();
            this.btnCancelModif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreModif.Location = new System.Drawing.Point(226, 59);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(135, 23);
            this.txtNombreModif.TabIndex = 0;
            this.txtNombreModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreModif_KeyPress);
            // 
            // txtApe1Modif
            // 
            this.txtApe1Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtApe1Modif.Location = new System.Drawing.Point(226, 126);
            this.txtApe1Modif.Name = "txtApe1Modif";
            this.txtApe1Modif.Size = new System.Drawing.Size(135, 23);
            this.txtApe1Modif.TabIndex = 1;
            this.txtApe1Modif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe1Modif_KeyPress);
            // 
            // txtApe2Modif
            // 
            this.txtApe2Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtApe2Modif.Location = new System.Drawing.Point(227, 202);
            this.txtApe2Modif.Name = "txtApe2Modif";
            this.txtApe2Modif.Size = new System.Drawing.Size(134, 23);
            this.txtApe2Modif.TabIndex = 2;
            this.txtApe2Modif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe2Modif_KeyPress);
            // 
            // txtDniModif
            // 
            this.txtDniModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDniModif.Location = new System.Drawing.Point(227, 276);
            this.txtDniModif.Name = "txtDniModif";
            this.txtDniModif.Size = new System.Drawing.Size(134, 23);
            this.txtDniModif.TabIndex = 3;
            // 
            // btnGuardarModif
            // 
            this.btnGuardarModif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardarModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModif.Location = new System.Drawing.Point(65, 358);
            this.btnGuardarModif.Name = "btnGuardarModif";
            this.btnGuardarModif.Size = new System.Drawing.Size(129, 38);
            this.btnGuardarModif.TabIndex = 4;
            this.btnGuardarModif.Text = "Guardar";
            this.btnGuardarModif.UseVisualStyleBackColor = false;
            this.btnGuardarModif.Click += new System.EventHandler(this.btnGuardarModif_Click);
            // 
            // btnCancelModif
            // 
            this.btnCancelModif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelModif.Location = new System.Drawing.Point(225, 358);
            this.btnCancelModif.Name = "btnCancelModif";
            this.btnCancelModif.Size = new System.Drawing.Size(129, 38);
            this.btnCancelModif.TabIndex = 5;
            this.btnCancelModif.Text = "Cancelar";
            this.btnCancelModif.UseVisualStyleBackColor = false;
            this.btnCancelModif.Click += new System.EventHandler(this.btnCancelModif_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Segundo apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Primer apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(62, 326);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(299, 18);
            this.lblAdvertencia.TabIndex = 15;
            this.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelModif);
            this.Controls.Add(this.btnGuardarModif);
            this.Controls.Add(this.txtDniModif);
            this.Controls.Add(this.txtApe2Modif);
            this.Controls.Add(this.txtApe1Modif);
            this.Controls.Add(this.txtNombreModif);
            this.Name = "FormModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreModif;
        private System.Windows.Forms.TextBox txtApe1Modif;
        private System.Windows.Forms.TextBox txtApe2Modif;
        private System.Windows.Forms.TextBox txtDniModif;
        private System.Windows.Forms.Button btnGuardarModif;
        private System.Windows.Forms.Button btnCancelModif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}