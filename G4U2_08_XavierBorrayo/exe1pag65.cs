internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act1pag65inc1===");
        int totalBoletos = 0;
        double totalDinero = 0;
        int opcion;

        do
        {
            Console.WriteLine("Nueva Venta\n");
            Console.WriteLine("1. Adulto ($15)\n2. Niño ($10)\n3. Salir y Cerrar");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                totalBoletos++;
                totalDinero += 15;
            }
            else if (opcion == 2)
            {
                totalBoletos++;
                totalDinero += 10;
            }

            Console.WriteLine("Estado: "+totalBoletos+"boletos vendidos |"+"Recaudado: "+totalDinero);

        } while (opcion != 3);

        Console.WriteLine("\n*** REPORTE FINAL ***");
        Console.WriteLine("Total boletos: "+totalBoletos);
        Console.WriteLine("Total Cobrado: "+totalDinero);
    }
}