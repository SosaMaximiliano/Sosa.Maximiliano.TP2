using Entidades;
namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        FrmPartida frmPartida;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ParticipantesDB jugadoresDB = new ParticipantesDB();
            Torneo.Participantes = jugadoresDB.ObtenerJugadores();

            dgSalas.DataSource = null;
            dgSalas.DataSource = Torneo.Salas;



        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                frmPartida = new FrmPartida();
                frmPartida.ShowDialog();

            });

        }

    }
}