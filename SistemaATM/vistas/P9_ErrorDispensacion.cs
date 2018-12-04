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
    public partial class P9_ErrorDispensacion : Form, Pantalla
    {
        public P9_ErrorDispensacion()
        {
            InitializeComponent();
        }

        public void aceptarBtn_click(string dato)
        {
            P7_HacerRetiro p7 = new P7_HacerRetiro();
            p7.Show();
            this.Close();
        }

        public void cancelarBtn_click()
        {
            P1_IngresoTargeta.referencia.Visible = true;
            this.Close();
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.Datos_txb.Visible = false;
        }
    }
}