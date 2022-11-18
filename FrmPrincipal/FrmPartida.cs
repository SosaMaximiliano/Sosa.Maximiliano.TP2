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

        public FrmPartida()
        {
            InitializeComponent();

            mano = 0;
            DMostrarJuego = ActualizarDatos;

            sala = new Sala(DMostrarJuego);
            Torneo.Salas.Add(sala);

            DGanador = sala.HayGanador;

            lblNombreJ1.Text = sala.Jugador1.Nombre;
            lblNombreJ2.Text = sala.Jugador2.Nombre;
        }



         void ActualizarDatos(string textoJ1, string textoJ2)
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

            if (this.richTextBox1.InvokeRequired)//Si el control es requerido desde otro hilo...
            {
                //Invoco la referencia del control a traves de un delegado
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
                });
            }


        }

        private void btnCancelarPartida_Click(object sender, EventArgs e)
        {
            //cancellation.Cancel();
        }

        private void FrmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

