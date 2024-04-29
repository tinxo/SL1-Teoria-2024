namespace C4_290424
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngresado = this.txtNombrePersona.Text;
            if (nombreIngresado == "")
            {
                MessageBox.Show("Se debe ingresar un valor.");
            }
            else
            {
                // Tengo que cargar la listbox con ese valor
                this.lstAsistentes.Items.Add(nombreIngresado);
            }
        }
    }
}
