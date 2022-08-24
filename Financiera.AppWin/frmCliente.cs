using Financiera.Logic;

namespace Financiera.AppWin
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvListado.DataSource = ClienteBL.Listar();
        }
    }
}