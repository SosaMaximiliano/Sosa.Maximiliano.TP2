using Entidades;
using System.Media;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        //FrmPartida frmPartida;
        public List<FrmPartida> listaPartidas;
        public static int idFormPartida;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ParticipantesDB jugadoresDB = new ParticipantesDB();
            Torneo.Participantes = jugadoresDB.ObtenerJugadores();
            this.BackgroundImage = Vista.Properties.Resources.pañoRojo;
            listaPartidas = new List<FrmPartida>();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            idFormPartida++;

            Task tarea = Task.Run(() =>
            {
                IniciarNuevaPartida();
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

        private void dgSalas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; 

            int indicePartida = int.Parse(dgSalas.Rows[row].Cells[0].Value.ToString());

            listaPartidas.ForEach((z) =>
            {
                if (z.idForm == indicePartida)
                {
                    z.Show();
                }
            });
        }

        public void IniciarNuevaPartida()
        {
            listaPartidas.Add(new FrmPartida());
        }
    }
}