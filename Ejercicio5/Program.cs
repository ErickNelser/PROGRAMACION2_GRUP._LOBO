using System.ComponentModel;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOTAL_COMUNIDADES = 8;
            const int UMBRAL_FAMILIAS = 120;
            int comunidadesCumplen = 0;
            int comunidadesNoCumplen = 0;
            for (int i = 1; i <= TOTAL_COMUNIDADES; i++)
            {
                Console.WriteLine("Ingrese las familias cubiertas en la comunidad" + i + ":");
                int familias = int.Parse(Console.ReadLine());
                if (familias >= UMBRAL_FAMILIAS)
                {
                    Console.WriteLine("Estado: CUMPLE");
                    comunidadesCumplen++;
                }
                else
                {
                    Console.WriteLine("Estado: NO CUMPLE");
                    comunidadesNoCumplen++;
                }

            }
            Console.WriteLine("RESUMEN DEL PROYECTO");
            Console.WriteLine("Comunidades que cumplen el umbral:" + comunidadesCumplen);
            Console.WriteLine("Comunidades que no cumplen" + comunidadesNoCumplen);
        }
    }
}
