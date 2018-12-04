namespace SistemaATM.vistas
{
    partial class P13_InsertarDeposito
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_dosMil = new System.Windows.Forms.MaskedTextBox();
            this.tbx_mil = new System.Windows.Forms.MaskedTextBox();
            this.tbx_quinientos = new System.Windows.Forms.MaskedTextBox();
            this.tbx_doscientos = new System.Windows.Forms.MaskedTextBox();
            this.tbx_cien = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(143, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, introduzca la cantidad a depositar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaATM.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(137, 221);
            this.tableroNumerico1.LongitudCampo = 20;
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 220);
            this.tableroNumerico1.TabIndex = 15;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(73, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Deposito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "2000";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbx_cien);
            this.panel1.Controls.Add(this.tbx_doscientos);
            this.panel1.Controls.Add(this.tbx_quinientos);
            this.panel1.Controls.Add(this.tbx_mil);
            this.panel1.Controls.Add(this.tbx_dosMil);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(575, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 256);
            this.panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(26, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(26, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "100";
            // 
            // tbx_dosMil
            // 
            this.tbx_dosMil.Location = new System.Drawing.Point(71, 59);
            this.tbx_dosMil.Mask = "00000";
            this.tbx_dosMil.Name = "tbx_dosMil";
            this.tbx_dosMil.Size = new System.Drawing.Size(100, 20);
            this.tbx_dosMil.TabIndex = 26;
            this.tbx_dosMil.ValidatingType = typeof(int);
            // 
            // tbx_mil
            // 
            this.tbx_mil.Location = new System.Drawing.Point(71, 102);
            this.tbx_mil.Mask = "00000";
            this.tbx_mil.Name = "tbx_mil";
            this.tbx_mil.Size = new System.Drawing.Size(100, 20);
            this.tbx_mil.TabIndex = 27;
            this.tbx_mil.ValidatingType = typeof(int);
            // 
            // tbx_quinientos
            // 
            this.tbx_quinientos.Location = new System.Drawing.Point(71, 141);
            this.tbx_quinientos.Mask = "00000";
            this.tbx_quinientos.Name = "tbx_quinientos";
            this.tbx_quinientos.Size = new System.Drawing.Size(100, 20);
            this.tbx_quinientos.TabIndex = 28;
            this.tbx_quinientos.ValidatingType = typeof(int);
            // 
            // tbx_doscientos
            // 
            this.tbx_doscientos.Location = new System.Drawing.Point(71, 185);
            this.tbx_doscientos.Mask = "00000";
            this.tbx_doscientos.Name = "tbx_doscientos";
            this.tbx_doscientos.Size = new System.Drawing.Size(100, 20);
            this.tbx_doscientos.TabIndex = 29;
            this.tbx_doscientos.ValidatingType = typeof(int);
            // 
            // tbx_cien
            // 
            this.tbx_cien.Location = new System.Drawing.Point(71, 220);
            this.tbx_cien.Mask = "00000";
            this.tbx_cien.Name = "tbx_cien";
            this.tbx_cien.Size = new System.Drawing.Size(100, 20);
            this.tbx_cien.TabIndex = 30;
            this.tbx_cien.ValidatingType = typeof(int);
            // 
            // P13_InsertarDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "P13_InsertarDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla13";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TableroNumerico tableroNumerico1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbx_cien;
        private System.Windows.Forms.MaskedTextBox tbx_doscientos;
        private System.Windows.Forms.MaskedTextBox tbx_quinientos;
        private System.Windows.Forms.MaskedTextBox tbx_mil;
        private System.Windows.Forms.MaskedTextBox tbx_dosMil;
    }
}