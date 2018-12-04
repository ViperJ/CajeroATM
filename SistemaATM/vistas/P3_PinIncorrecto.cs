﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public partial class P3_PinIncorrecto : Form, Pantalla
    {

        private Form pantAnterior;
        public Form PantAnterior { get => pantAnterior; set => pantAnterior = value; }

        public P3_PinIncorrecto()
        {
            InitializeComponent();
        }

        public void aceptarBtn_click(string dato)
        {
            P2_IngresoPin.referencia.Show();
            this.Close();
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Show();
            this.Close();
        }

        private void P3_PinIncorrecto_Load(object sender, EventArgs e)
        {
            
        }

        private void P3_PinIncorrecto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //P1_IngresoTargeta.referencia.Visible = true;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.Datos_txb.Visible = false;
        }
    }
}
