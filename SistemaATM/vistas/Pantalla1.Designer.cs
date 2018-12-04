namespace SistemaATM.vistas
{
    partial class Pantalla1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoTarjeta_lb = new System.Windows.Forms.Label();
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            this.sql_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(264, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(174, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor, inserte su tarjeta de credito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "BANCO EL INVOLUCRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tipoTarjeta_lb
            // 
            this.tipoTarjeta_lb.AutoSize = true;
            this.tipoTarjeta_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTarjeta_lb.ForeColor = System.Drawing.Color.Red;
            this.tipoTarjeta_lb.Location = new System.Drawing.Point(529, 152);
            this.tipoTarjeta_lb.Name = "tipoTarjeta_lb";
            this.tipoTarjeta_lb.Size = new System.Drawing.Size(79, 29);
            this.tipoTarjeta_lb.TabIndex = 5;
            this.tipoTarjeta_lb.Text = "label4";
            this.tipoTarjeta_lb.Visible = false;
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(125, 152);
            this.tableroNumerico1.LongitudCampo = 16;
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 283);
            this.tableroNumerico1.TabIndex = 4;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // sql_label
            // 
            this.sql_label.AutoSize = true;
            this.sql_label.Location = new System.Drawing.Point(64, 143);
            this.sql_label.Name = "sql_label";
            this.sql_label.Size = new System.Drawing.Size(35, 13);
            this.sql_label.TabIndex = 6;
            this.sql_label.Text = "label4";
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 453);
            this.Controls.Add(this.sql_label);
            this.Controls.Add(this.tipoTarjeta_lb);
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla1";
            this.Text = "Pantalla1";
            this.Activated += new System.EventHandler(this.Pantalla1_Activated);
            this.Load += new System.EventHandler(this.Pantalla1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private vistas.TableroNumerico tableroNumerico1;
        private System.Windows.Forms.Label tipoTarjeta_lb;
        private System.Windows.Forms.Label sql_label;
    }
}

