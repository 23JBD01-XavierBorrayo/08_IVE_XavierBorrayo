internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #10===");

        int cantidad, opcion;
        double precio = 650;
        double iva = 0.12;
        double precioConIVA, totalSinDescuento, descuento = 0, montoDescuento, totalPagar;

        Console.Write("Ingrese cantidad de impresoras: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        precioConIVA = precio + (precio * iva);

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                descuento = 0.10;
                break;
            case 2:
                descuento = 0.05;
                break;
            case 3:
                descuento = 0.15;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        totalSinDescuento = precioConIVA * cantidad;
        montoDescuento = totalSinDescuento * descuento;
        totalPagar = totalSinDescuento - montoDescuento;

        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio con IVA: Q" + precioConIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Descuento aplicado: Q" + montoDescuento);
        Console.WriteLine("Total a pagar: Q" + totalPagar);
    }
}