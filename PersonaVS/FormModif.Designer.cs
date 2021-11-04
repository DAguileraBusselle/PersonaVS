
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
            this.SuspendLayout();
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Location = new System.Drawing.Point(210, 64);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(135, 20);
            this.txtNombreModif.TabIndex = 0;
            // 
            // txtApe1Modif
            // 
            this.txtApe1Modif.Location = new System.Drawing.Point(210, 135);
            this.txtApe1Modif.Name = "txtApe1Modif";
            this.txtApe1Modif.Size = new System.Drawing.Size(135, 20);
            this.txtApe1Modif.TabIndex = 1;
            // 
            // txtApe2Modif
            // 
            this.txtApe2Modif.Location = new System.Drawing.Point(211, 207);
            this.txtApe2Modif.Name = "txtApe2Modif";
            this.txtApe2Modif.Size = new System.Drawing.Size(134, 20);
            this.txtApe2Modif.TabIndex = 2;
            // 
            // txtDniModif
            // 
            this.txtDniModif.Location = new System.Drawing.Point(211, 284);
            this.txtDniModif.Name = "txtDniModif";
            this.txtDniModif.Size = new System.Drawing.Size(134, 20);
            this.txtDniModif.TabIndex = 3;
            // 
            // btnGuardarModif
            // 
            this.btnGuardarModif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardarModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModif.Location = new System.Drawing.Point(56, 363);
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
            this.btnCancelModif.Location = new System.Drawing.Point(216, 363);
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
            this.label4.Location = new System.Drawing.Point(93, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Segundo apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Primer apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // FormModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
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
    }
}