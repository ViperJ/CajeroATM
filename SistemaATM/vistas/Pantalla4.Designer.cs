﻿namespace SistemaATM.vistas
{
    partial class Pantalla4
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
            this.tableroBotones_pnl = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableroBotones_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(238, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarjeta Invalida!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "BANCO EL INVOLUCRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableroBotones_pnl
            // 
            this.tableroBotones_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableroBotones_pnl.Controls.Add(this.button9);
            this.tableroBotones_pnl.Controls.Add(this.button10);
            this.tableroBotones_pnl.Location = new System.Drawing.Point(179, 372);
            this.tableroBotones_pnl.Name = "tableroBotones_pnl";
            this.tableroBotones_pnl.Size = new System.Drawing.Size(277, 54);
            this.tableroBotones_pnl.TabIndex = 8;
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
            // Pantalla4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(637, 438);
            this.Controls.Add(this.tableroBotones_pnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla4";
            this.Text = "Pantalla4";
            this.tableroBotones_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel tableroBotones_pnl;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}