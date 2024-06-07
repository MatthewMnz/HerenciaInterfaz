using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica
{
    internal class CelularDescuento: ICelular, IDescuento
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }

        public CelularDescuento (string marca, string modelo, double precio)
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

        public void AplicarDescuento(double porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
            {
                Console.WriteLine("El porcentaje de descuento tiene que estar entre 0 y 100");
                return;
            }
            Precio -= Precio * (porcentaje / 100);
        }
    }
}
