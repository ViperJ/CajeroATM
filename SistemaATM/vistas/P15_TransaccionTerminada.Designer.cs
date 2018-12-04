namespace SistemaATM.vistas
{
    partial class P15_TransaccionTerminada
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevoBalance_txb = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.transac_txb = new System.Windows.Forms.MaskedTextBox();
            this.transac_lb = new System.Windows.Forms.Label();
            this.tbx_cien = new System.Windows.Forms.MaskedTextBox();
            this.tbx_doscientos = new System.Windows.Forms.MaskedTextBox();
            this.tbx_quinientos = new System.Windows.Forms.MaskedTextBox();
            this.tbx_mil = new System.Windows.Forms.MaskedTextBox();
            this.tbx_dosMil = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(152, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, tome su recibo y tarjeta de credito.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(211, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gracias por preferirnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(159, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Por cierto, la tasa subira un 18% manana. :)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaATM.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(133, 221);
            this.tableroNumerico1.LongitudCampo = 20;
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 220);
            this.tableroNumerico1.TabIndex = 17;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nuevoBalance_txb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.transac_txb);
            this.panel1.Controls.Add(this.transac_lb);
            this.panel1.Controls.Add(this.tbx_cien);
            this.panel1.Controls.Add(this.tbx_doscientos);
            this.panel1.Controls.Add(this.tbx_quinientos);
            this.panel1.Controls.Add(this.tbx_mil);
            this.panel1.Controls.Add(this.tbx_dosMil);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(586, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 342);
            this.panel1.TabIndex = 20;
            // 
            // nuevoBalance_txb
            // 
            this.nuevoBalance_txb.Location = new System.Drawing.Point(151, 67);
            this.nuevoBalance_txb.Mask = "00000";
            this.nuevoBalance_txb.Name = "nuevoBalance_txb";
            this.nuevoBalance_txb.ReadOnly = true;
            this.nuevoBalance_txb.Size = new System.Drawing.Size(100, 20);
            this.nuevoBalance_txb.TabIndex = 34;
            this.nuevoBalance_txb.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(10, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nuevo Balance";
            // 
            // transac_txb
            // 
            this.transac_txb.Location = new System.Drawing.Point(151, 107);
            this.transac_txb.Mask = "00000";
            this.transac_txb.Name = "transac_txb";
            this.transac_txb.ReadOnly = true;
            this.transac_txb.Size = new System.Drawing.Size(100, 20);
            this.transac_txb.TabIndex = 32;
            this.transac_txb.ValidatingType = typeof(int);
            // 
            // transac_lb
            // 
            this.transac_lb.AutoSize = true;
            this.transac_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transac_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transac_lb.Location = new System.Drawing.Point(33, 105);
            this.transac_lb.Name = "transac_lb";
            this.transac_lb.Size = new System.Drawing.Size(106, 20);
            this.transac_lb.TabIndex = 31;
            this.transac_lb.Text = "Transaccion";
            // 
            // tbx_cien
            // 
            this.tbx_cien.Location = new System.Drawing.Point(151, 311);
            this.tbx_cien.Mask = "00000";
            this.tbx_cien.Name = "tbx_cien";
            this.tbx_cien.ReadOnly = true;
            this.tbx_cien.Size = new System.Drawing.Size(100, 20);
            this.tbx_cien.TabIndex = 30;
            this.tbx_cien.ValidatingType = typeof(int);
            // 
            // tbx_doscientos
            // 
            this.tbx_doscientos.Location = new System.Drawing.Point(151, 276);
            this.tbx_doscientos.Mask = "00000";
            this.tbx_doscientos.Name = "tbx_doscientos";
            this.tbx_doscientos.ReadOnly = true;
            this.tbx_doscientos.Size = new System.Drawing.Size(100, 20);
            this.tbx_doscientos.TabIndex = 29;
            this.tbx_doscientos.ValidatingType = typeof(int);
            // 
            // tbx_quinientos
            // 
            this.tbx_quinientos.Location = new System.Drawing.Point(151, 232);
            this.tbx_quinientos.Mask = "00000";
            this.tbx_quinientos.Name = "tbx_quinientos";
            this.tbx_quinientos.ReadOnly = true;
            this.tbx_quinientos.Size = new System.Drawing.Size(100, 20);
            this.tbx_quinientos.TabIndex = 28;
            this.tbx_quinientos.ValidatingType = typeof(int);
            // 
            // tbx_mil
            // 
            this.tbx_mil.Location = new System.Drawing.Point(151, 193);
            this.tbx_mil.Mask = "00000";
            this.tbx_mil.Name = "tbx_mil";
            this.tbx_mil.ReadOnly = true;
            this.tbx_mil.Size = new System.Drawing.Size(100, 20);
            this.tbx_mil.TabIndex = 27;
            this.tbx_mil.ValidatingType = typeof(int);
            // 
            // tbx_dosMil
            // 
            this.tbx_dosMil.Location = new System.Drawing.Point(151, 150);
            this.tbx_dosMil.Mask = "00000";
            this.tbx_dosMil.Name = "tbx_dosMil";
            this.tbx_dosMil.ReadOnly = true;
            this.tbx_dosMil.Size = new System.Drawing.Size(100, 20);
            this.tbx_dosMil.TabIndex = 26;
            this.tbx_dosMil.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(100, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(100, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(100, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(90, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(105, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Resultado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(96, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "2000";
            // 
            // P15_TransaccionTerminada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(866, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "P15_TransaccionTerminada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla15";
            this.Load += new System.EventHandler(this.P15_TransaccionTerminada_Load);
            this.VisibleChanged += new System.EventHandler(this.P15_TransaccionTerminada_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TableroNumerico tableroNumerico1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox transac_txb;
        private System.Windows.Forms.Label transac_lb;
        private System.Windows.Forms.MaskedTextBox tbx_cien;
        private System.Windows.Forms.MaskedTextBox tbx_doscientos;
        private System.Windows.Forms.MaskedTextBox tbx_quinientos;
        private System.Windows.Forms.MaskedTextBox tbx_mil;
        private System.Windows.Forms.MaskedTextBox tbx_dosMil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox nuevoBalance_txb;
        private System.Windows.Forms.Label label11;
    }
}