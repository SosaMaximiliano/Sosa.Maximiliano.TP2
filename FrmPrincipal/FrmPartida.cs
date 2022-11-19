using ClassLibrary1;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmPartida : Form
    {
        Sala sala;
        public int mano;
        Delegado.Ganador DGanador;
        Delegado.MostrarJuego DMostrarJuego;
        public int idForm;

        public FrmPartida()
        {
            InitializeComponent();

            mano = 0;
            DMostrarJuego = ActualizarDatos;

            sala = new Sala(DMostrarJuego);
            sala.IdSala = FrmPrincipal.idFormPartida;
            Torneo.Salas.Add(sala);

            DGanador = Sala.HayGanador;

            lblNombreJ1.Text = sala.Jugador1.Nombre;
            lblNombreJ2.Text = sala.Jugador2.Nombre;
        }



         public void ActualizarDatos(string textoJ1, string textoJ2)
        {
            if (this.lblMano.InvokeRequired)
            {
                this.lblMano.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblMano.Text = $"MANO: {sala.Mano}";
                });
            }

            if (this.lblPuntosJ1.InvokeRequired)
            {
                this.lblPuntosJ1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblPuntosJ1.Text = sala.Jugador1.Puntaje.ToString();
                });
            }

            if (this.lblPuntosJ2.InvokeRequired)
            {
                this.lblPuntosJ2.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblPuntosJ2.Text = sala.Jugador2.Puntaje.ToString();
                });
            }

            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.richTextBox1.AppendText(textoJ1);
                });
            }

            if (this.richTextBox2.InvokeRequired)
            {
                this.richTextBox2.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.richTextBox2.AppendText(textoJ2);
                    this.richTextBox2.ScrollToCaret();
                });
            }

            if (DGanador(sala.Jugador1) || DGanador(sala.Jugador2))
            {
                this.lblGanador.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblGanador.Text = $"GANADOR {Sala.JugadorGanador(sala.Jugador1,sala.Jugador2)}";

                });
            }


        }

        private void btnCancelarPartida_Click(object sender, EventArgs e)
        {
            sala.cts.Cancel();

            this.lblGanador.Text = "PARTIDA CANCELADA";
        }

        private void FrmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

