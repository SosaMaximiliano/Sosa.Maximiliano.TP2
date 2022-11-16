using Entidades;
namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        FrmPartida frmPartida;
        public static List<string> ListaParticipantes;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ParticipantesDB jugadoresDB = new ParticipantesDB();
            ListaParticipantes = jugadoresDB.ObtenerJugadores();

            dgSalas.DataSource = null;
            dgSalas.DataSource = ListaParticipantes;

            //dgSalas = ListaParticipantes[0];
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