using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica
{
    internal class Celular : ICelular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }

        public Celular(string marca, string modelo, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }

        public string ObtenerDetalles()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}";
        }

        public double ObtenerPrecio()
        {
            return Precio;
        }
    }
}
