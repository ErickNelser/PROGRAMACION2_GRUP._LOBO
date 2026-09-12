using System.Diagnostics;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOTAL_CONTROLES = 6;
            int controlActual = 1;  //Inicializacion
            //Condicion
            while (controlActual <= TOTAL_CONTROLES)
            {
                Console.WriteLine("Control nutricional registrado:" + controlActual);
                controlActual++; //Actualizacion 
            }
            Console.WriteLine("Total de controles procesados:" + TOTAL_CONTROLES);


        }
    }
}