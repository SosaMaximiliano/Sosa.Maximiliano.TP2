using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmPartida : Form
    {
        Sala sala;
        Jugador jugador1;
        Jugador jugador2;
        TirarDados jugar; //DELEGADO
        Jugar juegueNomas;
        StringBuilder sb;
        private int mano;

        public FrmPartida()
        {
            InitializeComponent();

            juegueNomas = Tarea01;

            sb = new StringBuilder();

            jugador1 = new Jugador("Gary", "Kasparov"); // EL NOMBRE TIENE QUE VENIR DE UNA VARIABLE SELECT DE LA DB
            jugador2 = new Jugador("Bobby", "Fisher");

            sala = new Sala(515, jugador1, jugador2);

            Torneo.Salas.Add(sala);

            mano = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juegueNomas(jugador1); //COMO MIERDA USO EL DELEGADO?

            lblMano.Text = $"MANO: {++mano}";
            sb.Clear();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine($"Tiro N° {i + 1}");
                Task tarea1 = Task.Run(Tarea01);
                tarea1.Wait();
                richTextBox1.Text = sb.ToString();
                lblPuntosJ1.Text = jugador1.Puntaje.ToString();
            }

            sb.Clear();

            Thread.Sleep(1000);

            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine($"Tiro N° {i + 1}");
                Task tarea2 = Task.Run(Tarea02);
                tarea2.Wait();
                richTextBox2.Text = sb.ToString();
                lblPuntosJ2.Text = jugador2.Puntaje.ToString();
            }

            /*Task tarea3 = Task.Run(Tarea03);
            tarea3.Wait();
            richTextBox2.Text = sb.ToString();*/


        }

        public void Tarea01()
        {
            Thread.Sleep(2000);
            sb.Append(jugador1.JugarMano());
            sb.AppendLine();

        }

        public void Tarea01(Jugador jugador)
        {
            Thread.Sleep(2000);
            sb.Append(jugador.JugarMano());
            sb.AppendLine();

        }

        public void Tarea02()
        {
            Thread.Sleep(2000);
            sb.Append(jugador2.JugarMano());
            sb.AppendLine();

        }

        public void Tarea03()
        {

            sb.Clear();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(2000);
                sb.AppendLine($"Tiro N° {i + 1}");
                sb.Append(jugador2.JugarMano());
                sb.AppendLine();
            }


        }
    }
}

