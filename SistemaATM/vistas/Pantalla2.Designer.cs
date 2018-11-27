namespace SistemaATM.vistas
{
    partial class Pantalla2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(141, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor entre su PIN de cuatro digitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "BANCO EL INVOLUCRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(128, 168);
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 275);
            this.tableroNumerico1.TabIndex = 7;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 422);
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla2";
            this.Text = "Pantalla2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private TableroNumerico tableroNumerico1;
    }
}