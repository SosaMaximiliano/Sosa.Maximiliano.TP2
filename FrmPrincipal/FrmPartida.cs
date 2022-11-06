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
        StringBuilder sb;

        public FrmPartida()
        {
            InitializeComponent();

            jugador1 = new Jugador("Gary", "Kasparov",515);
            jugador2 = new Jugador("Bobby", "Fisher",515);

            sala = new Sala(515, jugador1, jugador2);
            
            sb = new StringBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = jugador1.JugarMano();

            
            
        }
    }
}

