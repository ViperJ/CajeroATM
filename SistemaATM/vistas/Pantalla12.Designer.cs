namespace SistemaATM.vistas
{
    partial class Pantalla12
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
            this.tableroBotones_pnl = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableroBotones_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "La transaccion de deposito no pudo ser procesada!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desea realizar otra transaccion?";
            // 
            // tableroBotones_pnl
            // 
            this.tableroBotones_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableroBotones_pnl.Controls.Add(this.button9);
            this.tableroBotones_pnl.Controls.Add(this.button10);
            this.tableroBotones_pnl.Location = new System.Drawing.Point(154, 288);
            this.tableroBotones_pnl.Name = "tableroBotones_pnl";
            this.tableroBotones_pnl.Size = new System.Drawing.Size(277, 54);
            this.tableroBotones_pnl.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(22, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 40);
            this.button9.TabIndex = 12;
            this.button9.Text = "Aceptar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(142, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 40);
            this.button10.TabIndex = 5;
            this.button10.Text = "Cancelar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Pantalla12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 354);
            this.Controls.Add(this.tableroBotones_pnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla12";
            this.Text = "Pantalla12";
            this.tableroBotones_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel tableroBotones_pnl;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}