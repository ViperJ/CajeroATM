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
            this.aceptar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
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
            // aceptar_btn
            // 
            this.aceptar_btn.Location = new System.Drawing.Point(205, 199);
            this.aceptar_btn.Name = "aceptar_btn";
            this.aceptar_btn.Size = new System.Drawing.Size(114, 40);
            this.aceptar_btn.TabIndex = 13;
            this.aceptar_btn.Text = "Aceptar";
            this.aceptar_btn.UseVisualStyleBackColor = true;
            this.aceptar_btn.Click += new System.EventHandler(this.aceptar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(335, 199);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(114, 40);
            this.cancelar_btn.TabIndex = 14;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // Pantalla4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(637, 438);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.aceptar_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla4";
            this.Text = "Pantalla4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aceptar_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}