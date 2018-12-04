namespace SistemaATM.vistas
{
    partial class P6_VerBalance
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
            this.balance_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableroNumerico1 = new SistemaATM.vistas.TableroNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(195, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su balance es:";
            // 
            // balance_lb
            // 
            this.balance_lb.AutoSize = true;
            this.balance_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.balance_lb.Location = new System.Drawing.Point(341, 167);
            this.balance_lb.Name = "balance_lb";
            this.balance_lb.Size = new System.Drawing.Size(99, 24);
            this.balance_lb.TabIndex = 1;
            this.balance_lb.Text = "$dddd.dd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaATM.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tableroNumerico1
            // 
            this.tableroNumerico1.Location = new System.Drawing.Point(141, 221);
            this.tableroNumerico1.LongitudCampo = 20;
            this.tableroNumerico1.Name = "tableroNumerico1";
            this.tableroNumerico1.NombreCampo = null;
            this.tableroNumerico1.Pantalla = null;
            this.tableroNumerico1.Size = new System.Drawing.Size(388, 220);
            this.tableroNumerico1.TabIndex = 11;
            this.tableroNumerico1.Load += new System.EventHandler(this.tableroNumerico1_Load);
            // 
            // P6_VerBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 453);
            this.ControlBox = false;
            this.Controls.Add(this.tableroNumerico1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balance_lb);
            this.Controls.Add(this.label1);
            this.Name = "P6_VerBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.P6_VerBalance_FormClosed);
            this.Load += new System.EventHandler(this.Pantalla6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balance_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TableroNumerico tableroNumerico1;
    }
}