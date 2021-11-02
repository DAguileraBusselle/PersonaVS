
namespace PersonaVS
{
    partial class FormModif
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
            this.txtNombreModif = new System.Windows.Forms.TextBox();
            this.txtApe1Modif = new System.Windows.Forms.TextBox();
            this.txtApe2Modif = new System.Windows.Forms.TextBox();
            this.txtDniModif = new System.Windows.Forms.TextBox();
            this.btnGuardarModif = new System.Windows.Forms.Button();
            this.btnCancelModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Location = new System.Drawing.Point(205, 74);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(108, 20);
            this.txtNombreModif.TabIndex = 0;
            // 
            // txtApe1Modif
            // 
            this.txtApe1Modif.Location = new System.Drawing.Point(205, 142);
            this.txtApe1Modif.Name = "txtApe1Modif";
            this.txtApe1Modif.Size = new System.Drawing.Size(108, 20);
            this.txtApe1Modif.TabIndex = 1;
            // 
            // txtApe2Modif
            // 
            this.txtApe2Modif.Location = new System.Drawing.Point(205, 207);
            this.txtApe2Modif.Name = "txtApe2Modif";
            this.txtApe2Modif.Size = new System.Drawing.Size(107, 20);
            this.txtApe2Modif.TabIndex = 2;
            // 
            // txtDniModif
            // 
            this.txtDniModif.Location = new System.Drawing.Point(209, 270);
            this.txtDniModif.Name = "txtDniModif";
            this.txtDniModif.Size = new System.Drawing.Size(104, 20);
            this.txtDniModif.TabIndex = 3;
            // 
            // btnGuardarModif
            // 
            this.btnGuardarModif.Location = new System.Drawing.Point(216, 337);
            this.btnGuardarModif.Name = "btnGuardarModif";
            this.btnGuardarModif.Size = new System.Drawing.Size(96, 22);
            this.btnGuardarModif.TabIndex = 4;
            this.btnGuardarModif.Text = "Guardar";
            this.btnGuardarModif.UseVisualStyleBackColor = false;
            this.btnGuardarModif.Click += new System.EventHandler(this.btnGuardarModif_Click);
            // 
            // btnCancelModif
            // 
            this.btnCancelModif.Location = new System.Drawing.Point(216, 389);
            this.btnCancelModif.Name = "btnCancelModif";
            this.btnCancelModif.Size = new System.Drawing.Size(96, 24);
            this.btnCancelModif.TabIndex = 5;
            this.btnCancelModif.Text = "Cancelar";
            this.btnCancelModif.UseVisualStyleBackColor = true;
            this.btnCancelModif.Click += new System.EventHandler(this.btnCancelModif_Click);
            // 
            // FormModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.btnCancelModif);
            this.Controls.Add(this.btnGuardarModif);
            this.Controls.Add(this.txtDniModif);
            this.Controls.Add(this.txtApe2Modif);
            this.Controls.Add(this.txtApe1Modif);
            this.Controls.Add(this.txtNombreModif);
            this.Name = "FormModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModif";
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
    }
}