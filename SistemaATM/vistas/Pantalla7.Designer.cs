namespace SistemaATM.vistas
{
    partial class Pantalla7
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
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre la cantidad (en multiplos de 10)";
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(110, 156);
            this.tableroNumerico1.LongitudCampo = 16;
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 275);
            this.tableroNumerico1.TabIndex = 1;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // Pantalla7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 438);
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla7";
            this.Text = "Pantalla7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TableroNumerico tableroNumerico1;
    }
}