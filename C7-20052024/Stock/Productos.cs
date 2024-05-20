using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_20052024.Stock
{
    public class Productos
    {
        // Definición de atributos
        private string _id;
        private string _nombre;
        private string _descripcion;
        private int _stockActual;
        private int _stockMinimo;

        // Definición del constructor
        public Productos(string id, string nombre, string descripcion)
        {
            // Inicialización de los valores de los atributos
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _stockMinimo = 0; // Valor por regla de negocio
            _stockActual = 0; // Valor por regla de negocio
        }

        // Definición de propiedades
        public string Id { get; } // Propiedad de solo lectura
        public string Nombre 
        {
            get { return  _nombre; }
            set 
            { 
                if (value != String.Empty)
                {
                    _nombre = value;
                }
            }
        }

    }
}
