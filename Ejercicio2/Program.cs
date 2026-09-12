namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int META_RACIONES = 8000;
            const int TOTAL_ESCUELAS = 8;
            int sumaRaciones = 0;
            int contadorEscolar = 1;
            Console.WriteLine("CONTROL DE DESAYUNO ESCOLAR - MUNICIPIO SUCRE");
            while (contadorEscolar <= TOTAL_ESCUELAS)
            {
                Console.WriteLine("Ingrese las raciones entregadas en la escuela" + contadorEscolar + ":");
                int racionesJornada = int.Parse(Console.ReadLine());
                sumaRaciones = sumaRaciones + racionesJornada;
                contadorEscolar++;
            }
            Console.WriteLine("\n --- Reporte Final ---");
            Console.WriteLine("Total acumulado de raciones entregadas:" + sumaRaciones);
            if (sumaRaciones >= META_RACIONES)
            {
                Console.WriteLine("Resultado: Se alcanzo la meta de" + META_RACIONES + "raciones");
            }
            else
            {
                Console.WriteLine("Resultado: No se alcanzo la meta. Faltaron" + (META_RACIONES - sumaRaciones) + "raciones");
            }




        }
    }
}
