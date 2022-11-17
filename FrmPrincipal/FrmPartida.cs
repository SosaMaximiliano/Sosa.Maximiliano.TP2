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
        Ganador DGanador;
        MostrarJuego DMostrarJuego;

        public FrmPartida()
        {
            InitializeComponent();

            mano = 0;

            sala = new Sala(ActualizarRch);
            Torneo.Salas.Add(sala);

            //DELEGADOS
            //DTirar = sala.JugarPartida;
            //DMostrarJuego = sala.Jugador1.MostrarJuego;
            DGanador = sala.HayGanador;

            lblNombreJ1.Text = sala.Jugador1.Nombre;
            lblNombreJ2.Text = sala.Jugador2.Nombre;
        }



        public void ActualizarRch(string textoJ1, string textoJ2)
        {
            //lblMano.Text = $"MANO: {sala.Mano}";

            if (this.richTextBox1.InvokeRequired)//Si el control es requerido desde otro hilo...
            {
                //Invoco la referencia del control a traves de un delegado
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.richTextBox1.AppendText(textoJ1);
                });
            }

            /*else //Si no fue requerido trabaja sobre el hilo en el que se creó
            {
                this.richTextBox1.AppendText(texto);
            }*/



            if (this.richTextBox2.InvokeRequired)
            {
                this.richTextBox2.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.richTextBox2.AppendText(textoJ2);
                });
            }

            /* else
             {
                 this.richTextBox2.AppendText(texto);
             }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ActualizarRch(ct, $"METODO LLAMADO DESDE EL HILO PRINCIPAL\n");
        }

        private void FrmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("La concha de la lora");
            e.Cancel = true;
            this.Hide();
        }
    }
}

