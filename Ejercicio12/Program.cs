namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int TOTAL_OBJETOS = 4;
            const int UMBRAL_ALTO = 150;
            const int UMBRAL_MEDIO = 60;
            int confirmados = 0;
            int pendientes = 0;
            //Condicion
            for (int i = 1; i <= TOTAL_OBJETOS; i++)
            {
                Console.Write("Ingrese el valor del objeto historico" + i + ":");
                int valorInventario = int.Parse(Console.ReadLine());
                if (valorInventario >= UMBRAL_ALTO)
                {
                    Console.Write("Fue verificado en campo? (1 = si, 2 = no):");
                    int verificacion = int.Parse(Console.ReadLine());
                    if (verificacion == 1)
                    {
                        Console.WriteLine("Resultado: INVENTARIO ALTO CONFIRMADO");
                        pendientes++;
                    }
                }
                else if (valorInventario >= UMBRAL_MEDIO)
                {
                    Console.WriteLine("Resultado:INVENTARIO MEDIO");
                }
                else
                {
                    Console.WriteLine("INVENTARIO BAJO");
                }
            }
            Console.WriteLine("REPORTE FINAL");
            Console.WriteLine("Objetos ALTOS CONFIRMADOS:" + confirmados);
            Console.WriteLine("Objetos ALTOS PENDIENTES:" + pendientes);

        }
    }
}
