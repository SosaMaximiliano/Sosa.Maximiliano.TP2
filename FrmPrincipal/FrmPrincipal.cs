using Entidades;
using System.Media;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        FrmPartida frmPartida;
        public static int idFormPartida;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ParticipantesDB jugadoresDB = new ParticipantesDB();
            Torneo.Participantes = jugadoresDB.ObtenerJugadores();

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            idFormPartida++;

            Task tarea = Task.Run(() =>
            {
                frmPartida = new FrmPartida();
                frmPartida.ShowDialog();

            });
            btnIniciarJuego.Enabled = false;
            Thread.Sleep(1000);
            btnIniciarJuego.Enabled = true;

            this.dgSalas.DataSource = null;
            this.dgSalas.DataSource = Torneo.Salas;

        }

        private void rdbRojo_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Vista.Properties.Resources.pañoRojo;
        }

        private void rdbVerde_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Vista.Properties.Resources.paño;
        }

        private void rdbAzul_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Vista.Properties.Resources.pañoAzul;
        }

        private void dgSalas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         //   int idAux =(int) dgSalas.Rows[e.RowIndex].Cells[0].Value;

        }
    }
}