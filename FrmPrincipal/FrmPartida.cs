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
using static Entidades.Delegado;

namespace FrmPrincipal
{
    public partial class FrmPartida : Form
    {
        Sala sala;
        public int mano;
        Tirar DTirar;
        Ganador DGanador;
        MostrarJuego DMostrarJuego;
        int random;
        Random rand = new Random();

        public FrmPartida()
        {
            InitializeComponent();

            string nombreJ1 = FrmPrincipal.ListaParticipantes[rand.Next(0, 100)];
            string nombreJ2 = FrmPrincipal.ListaParticipantes[rand.Next(0, 100)];

            mano = 0;

            sala = new Sala(515, nombreJ1, nombreJ2);
            Torneo.Salas.Add(sala);
            Torneo.Contrincantes.Add(sala.Jugador1);

            //DELEGADOS
            //DTirar = sala.JugarPartida;
            DGanador = sala.HayGanador;
            DMostrarJuego = sala.Jugador1.MostrarJuego;

            lblNombreJ1.Text = nombreJ1;
            lblNombreJ2.Text = nombreJ2;
        }

        public Sala Sala { get => sala; }

        private void button1_Click(object sender, EventArgs e)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

            lblMano.Text = $"MANO: {sala.Mano}";

        }


        public void MostrarJugada(string jugada)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                this.BeginInvoke(DMostrarJuego);
            }
            else
                richTextBox1.Text += "LPM";
        }
        
    }
}

