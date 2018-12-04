namespace SistemaATM.vistas
{
    partial class P5_SeleccionTransaccion
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
            this.verBalance_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositar_btn = new System.Windows.Forms.Button();
            this.retirar_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(201, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la transaccion:";
            // 
            // verBalance_btn
            // 
            this.verBalance_btn.Location = new System.Drawing.Point(570, 201);
            this.verBalance_btn.Name = "verBalance_btn";
            this.verBalance_btn.Size = new System.Drawing.Size(61, 40);
            this.verBalance_btn.TabIndex = 1;
            this.verBalance_btn.UseVisualStyleBackColor = true;
            this.verBalance_btn.Click += new System.EventHandler(this.verBalance_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(462, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "BALANCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(453, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DEPOSITO";
            // 
            // depositar_btn
            // 
            this.depositar_btn.Location = new System.Drawing.Point(570, 320);
            this.depositar_btn.Name = "depositar_btn";
            this.depositar_btn.Size = new System.Drawing.Size(61, 40);
            this.depositar_btn.TabIndex = 4;
            this.depositar_btn.UseVisualStyleBackColor = true;
            this.depositar_btn.Click += new System.EventHandler(this.depositar_btn_Click);
            // 
            // retirar_btn
            // 
            this.retirar_btn.Location = new System.Drawing.Point(12, 201);
            this.retirar_btn.Name = "retirar_btn";
            this.retirar_btn.Size = new System.Drawing.Size(61, 40);
            this.retirar_btn.TabIndex = 6;
            this.retirar_btn.UseVisualStyleBackColor = true;
            this.retirar_btn.Click += new System.EventHandler(this.retirar_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(79, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "RETIRO";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(12, 320);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(61, 40);
            this.cancelar_btn.TabIndex = 8;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(79, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "CANCELAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaATM.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // P5_SeleccionTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 453);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.retirar_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositar_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verBalance_btn);
            this.Controls.Add(this.label1);
            this.Name = "P5_SeleccionTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verBalance_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button depositar_btn;
        private System.Windows.Forms.Button retirar_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}