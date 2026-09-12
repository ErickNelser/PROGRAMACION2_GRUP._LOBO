using System.ComponentModel.Design;

namespace Ejecicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int META_REGISTROS = 3000;
            int acumulado = 0;
            int contadorPeriodos = 0;
            //Condicion
            while (acumulado < META_REGISTROS)
            {
                Console.Write("Ingrese los registros de este periodo:");
                int registrosAportados = int.Parse(Console.ReadLine());

                if (registrosAportados == 0)
                {
                    Console.WriteLine("AVISO: El periodo fue declarado como improductivo.");
                }
                else
                {
                    acumulado = acumulado + registrosAportados;
                }
                contadorPeriodos++;
                int saldoFaltante = META_REGISTROS - acumulado;
                if (saldoFaltante > 0)
                {
                    Console.WriteLine("Slado pendiente para la meta:" + saldoFaltante);
                }
            }
            int excedente = acumulado - META_REGISTROS;
            Console.WriteLine("META ALCANZADA");
            Console.WriteLine("Total acumulado:" + acumulado);
            Console.WriteLine("Excedente:" + excedente);
            Console.WriteLine("Cantidad total de periodos usados:" + contadorPeriodos);


        }
    }
}
