namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int TOTAL_SENSORES = 6;
            const int UMBRAL_OPTIMA = 60;
            const int UMBRAL_ACEPTABLE = 35;

            int contadorOptima = 0;
            int contadorAceptable = 0;
            int contadorCritica = 0;
            //Condicion
            for (int sensor = 1; sensor <= TOTAL_SENSORES; sensor++) ;
            {
                Console.Write("Porcentaje de humedad del sensor" + TOTAL_SENSORES + ":");
                int humedad = int.Parse(Console.ReadLine());
                if (humedad >= UMBRAL_OPTIMA)
                {
                    Console.WriteLine("Clasificacion: HUMEDAD OPTIMA");
                    contadorOptima++;
                }
                else if (humedad >= UMBRAL_ACEPTABLE)
                {
                    Console.WriteLine("Clasificacion: HUMEDAD ACEPTABLE");
                    contadorAceptable++;

                }
                else
                {
                    Console.WriteLine("Clasificacion: HUMEDAD CRITICA");
                    contadorCritica++;
                }



            }
            Console.WriteLine("REPORTE FINAL");
            Console.WriteLine("Sensores en categoria optima:" + contadorOptima);
            Console.WriteLine("Sensores en categoria Aceptable:" + contadorAceptable);
            Console.WriteLine("Sensores en categoria Critica" + contadorCritica);
        }
    }
}
