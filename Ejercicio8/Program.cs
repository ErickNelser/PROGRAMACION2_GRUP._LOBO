namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int TOTAL_CRUCES = 8;
            int contadorCruce = 1;
            int totalTurnoManana = 0;
            int totalTurnoTrade = 0;
            //Condicion
            while (contadorCruce <= TOTAL_CRUCES)
            {
                if (contadorCruce % 2 == 0)
                {

                    Console.WriteLine("Cruce #" + contadorCruce + "Asignado el turno mañana.");
                    totalTurnoManana++;

                }
                else
                {
                    Console.WriteLine("Cruce #" + contadorCruce + "Asignado el turno tarde.");
                    totalTurnoTrade++;
                }
                contadorCruce++;

            }
            Console.WriteLine("Resumen Final");
            Console.WriteLine("Cruces en la mañana (pares):" + totalTurnoManana);
            Console.WriteLine("Cruces en la tarde (impares)" + totalTurnoTrade);
        }
    }
}
