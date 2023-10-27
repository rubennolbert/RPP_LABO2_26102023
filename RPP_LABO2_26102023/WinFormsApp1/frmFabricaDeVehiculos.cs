namespace WinFormsApp1
{
    public partial class frmFabricaDeVehiculos : Form
    {
        public frmFabricaDeVehiculos()
        {
            InitializeComponent();
        }

        private void frmFabricaDeVehiculos_Load(object sender, EventArgs e)
        {
            this.cmbTipoDeVehiculos.Items.AddRange(new object[] { "Moto", "Automovil", "Camioneta" });
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {

        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}