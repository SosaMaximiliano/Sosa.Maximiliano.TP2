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


        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            frmPartida = new FrmPartida();
            frmPartida.Show();

            dgSalas.DataSource = null;
            dgSalas.DataSource = Torneo.Salas;

        }
    }
}