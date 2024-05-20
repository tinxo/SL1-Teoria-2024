using C7_20052024.Stock;

namespace C7_20052024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos unProducto = new Productos("1234567880",
                "Termo Termolar 1lt",
                "Termo marca Termolar de 1lt de capacidad color negro");
            string nombreProducto = unProducto.Nombre;
            MessageBox.Show($"El producto creado fue: {nombreProducto}");
        }
    }
}
