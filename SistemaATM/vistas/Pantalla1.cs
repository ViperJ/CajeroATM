﻿using SistemaATM.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaATM.vistas
{
    public partial class Pantalla1 : Form, Pantalla
    {
        public static Form referencia;

        public Pantalla1()
        {
            InitializeComponent();
            referencia = this;
        }

        private void tableroNumerico1_Load(object sender, EventArgs e)
        {
            tableroNumerico1.Pantalla = this;
            tableroNumerico1.NombreCampo = "Tarjeta De Credito";
            tableroNumerico1.LongitudCampo = 20;
        }

        public void aceptarBtn_click(string dato)
        {
            string msj = "Hola Mundo";
            if (AyudanteValidacion.estaVacio(dato))
            {
                msj = "El campo Tarjeta de Credito no puede estar vacio!";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int longitudCampo = tableroNumerico1.LongitudCampo;
            if (!AyudanteValidacion.esLongitudValida(dato, 13, longitudCampo))
            {
                msj = string.Format("El campo Tarjeta de Credito no cumple con la longitud requerida! La longitud debe de ser {0}", longitudCampo);
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipo = AyudanteValidacion.validarTipoTarjeta(dato);
            if (tipo == "NO VALIDO")
            {
                msj = "El campo Tarjeta de Credito No Es Valido! Necesita Ser VISA O MASTERCARD";
                MessageBox.Show(this, msj, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tipoTarjeta_lb.Text = tipo;
                tipoTarjeta_lb.Visible = true;
            }

            string r;

            try
            {
                ConexionSQL conexionSql = new ConexionSQL();
                r = conexionSql.query("up_busca_tarjeta_pin", "NUMERO_TARJETA", "@NUMERO_TARJETA", dato);
                if (dato == r)
                {
                    Pantalla2 pantalla2 = new Pantalla2();
                    pantalla2.NumTarjeta = dato;
                    pantalla2.Show();
                    this.Hide();
                }
            }
            catch (Exception e)
            {
                if (e is SqlException || e is InvalidOperationException)
                    MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {
            tipoTarjeta_lb.Visible = false;
        }

        private void Pantalla1_Activated(object sender, EventArgs e)
        {

        }

        public void cancelar()
        {
            throw new NotImplementedException();
        }
    }
}
