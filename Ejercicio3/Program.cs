namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double LIMITE_MINIMO = 0.0;
            const double LIMITE_MAXIMO = 100.0;

            double velocidadBajada;
            Console.WriteLine("SISTEMA DE MEDICION ENTEL");
            do
            {
                Console.WriteLine("Ingrese la velosidad de bajada medida (en megabits por segundo:");
                velocidadBajada = double.Parse(Console.ReadLine());
                if (velocidadBajada < LIMITE_MINIMO || velocidadBajada > LIMITE_MAXIMO)
                {
                    Console.WriteLine("ERROR: Dato invalido. La velocidad debe estar obligatoriamente entre" + LIMITE_MINIMO + "Y" + "megabits por segundo");

                }
             
            } while (velocidadBajada < LIMITE_MINIMO || velocidadBajada > LIMITE_MAXIMO);
            Console.WriteLine("Carga exitosa. La velocidad de " + velocidadBajada + "Mbps ha sido registrada en el sistema");
        }
    }
}
