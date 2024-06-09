using C10_100624.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10_100624
{
    public partial class FrmProductos : Form
    {

        // Colección de productos para usar
        private List<Producto> _listaProductos = new List<Producto>();
        // Un producto en particular para usar
        private Producto _unProducto;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Se leen los valores desde la interfaz
            string idIngresado = txtID.Text;
            string nombreIngresado = txtNombre.Text;
            string descripcionIngresada = txtDescripcion.Text;
            double precioUnitarioIngresado = (double)nupPrecioUnitario.Value;
            int stockMinimo = (int)nupStockMinimo.Value;
            // Se genera el objeto Producto
            Producto productoTemp = new Producto(idIngresado,
                nombreIngresado, descripcionIngresada,
                precioUnitarioIngresado, stockMinimo);
            // Se carga en la lista en memoria
            this._listaProductos.Add(productoTemp);
            // Se carga en el listbox para visualización
            this.sincronizarListado();
        }

        private void btnCrearMovimiento_Click(object sender, EventArgs e)
        {
            // Se necesita un movimiento seleccionado
            _unProducto = this._listaProductos[0];
            // Se va a cargar un movimiento nuevo
            int cantidadIngresada = (int)this.nupCantidad.Value;
            string observacionesMovimiento = this.txtObservaciones.Text;
            if (this.cbxTipoMovimiento.SelectedIndex == 0)
            {
                // Ingreso
                _unProducto.agregarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
            }
            else
            {
                // Egreso
                _unProducto.restarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
            }
            // Se actualiza en el listbox la visualización
            this.sincronizarListado();
        }

        private void sincronizarListado()
        {
            this.lstProductos.Items.Clear();
            foreach (var producto in this._listaProductos)
            {
                this.lstProductos.Items.Add(producto);
            }
        }
    }
}
