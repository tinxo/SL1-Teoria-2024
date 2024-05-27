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
            // Se leen los valores desde la interfaz
            string idIngresado = txtID.Text;
            string nombreIngresado = txtNombre.Text;        
            string descripcionIngresada = txtDescripcion.Text;
            double precioUnitarioIngresado = (double)nupPrecioUnitario.Value;
            // Se genera el objeto Producto
            Productos unProducto = new Productos(idIngresado,
                nombreIngresado, descripcionIngresada,
                precioUnitarioIngresado);
            string nombreProducto = unProducto.Nombre;
            MessageBox.Show($"El producto creado fue: {nombreProducto}");
        }
    }
}
