namespace ClasePractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICelular celularNoDescuento = new Celular("Apple", "iPhone 11 Pro Max", 399);

            Console.WriteLine("Detalles del Celular sin descuento:");
            Console.WriteLine(celularNoDescuento.ObtenerDetalles());
            Console.WriteLine($"Precio: ${celularNoDescuento.ObtenerPrecio()}");

            CelularDescuento celularConDescuento = new CelularDescuento("Apple", "iPhone 11 Pro Max", 399);

            Console.WriteLine("Detalles del Celular con descuento:");
            Console.WriteLine(celularConDescuento.ObtenerDetalles());
            Console.WriteLine($"Precio Original: ${celularConDescuento.ObtenerPrecio()}");

            celularConDescuento.AplicarDescuento(10);
            Console.WriteLine($"Precio con descuento: ${celularConDescuento.ObtenerPrecio()}");

        }
    }
}
