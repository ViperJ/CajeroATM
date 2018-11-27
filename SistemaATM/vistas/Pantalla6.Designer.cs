namespace SistemaATM.vistas
{
    partial class Pantalla6
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
            this.aceptar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.tableroBotones_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su balance es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "$dddd.dd";
            // 
            // tableroBotones_pnl
            // 
            this.tableroBotones_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableroBotones_pnl.Controls.Add(this.aceptar_btn);
            this.tableroBotones_pnl.Controls.Add(this.cancelar_btn);
            this.tableroBotones_pnl.Location = new System.Drawing.Point(181, 339);
            this.tableroBotones_pnl.Name = "tableroBotones_pnl";
            this.tableroBotones_pnl.Size = new System.Drawing.Size(277, 54);
            this.tableroBotones_pnl.TabIndex = 9;
            // 
            // aceptar_btn
            // 
            this.aceptar_btn.Location = new System.Drawing.Point(22, 3);
            this.aceptar_btn.Name = "aceptar_btn";
            this.aceptar_btn.Size = new System.Drawing.Size(114, 40);
            this.aceptar_btn.TabIndex = 12;
            this.aceptar_btn.Text = "Aceptar";
            this.aceptar_btn.UseVisualStyleBackColor = true;
            this.aceptar_btn.Click += new System.EventHandler(this.aceptar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(142, 3);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(114, 40);
            this.cancelar_btn.TabIndex = 5;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // Pantalla6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 423);
            this.Controls.Add(this.tableroBotones_pnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla6";
            this.Text = "Pantalla6";
            this.tableroBotones_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel tableroBotones_pnl;
        private System.Windows.Forms.Button aceptar_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}