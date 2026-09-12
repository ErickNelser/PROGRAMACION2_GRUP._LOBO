namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int CANTIDAD_CONJUNTOS = 6;
            const double UMBRAL_ACEPTABLE = 150.0;
            int contador = 1;
            double sumaDescargas = 0;
            //Condicion
            while (contador <= CANTIDAD_CONJUNTOS)
            {
                Console.WriteLine("Ingrese las descargas de conjuntos " + contador + ":");
                double valor = double.Parse(Console.ReadLine());
                sumaDescargas = sumaDescargas + valor;
                contador++;
            }
            double promedio = sumaDescargas / CANTIDAD_CONJUNTOS;
            Console.WriteLine("promedio de descargas fue:" + promedio);
            if (promedio >= UMBRAL_ACEPTABLE)
            {
                Console.WriteLine("Diagnostico: La situacion de La Paz es ACEPTABLE");
            }
            else
            {
                Console.WriteLine("Diagnostico: La situacion REQUIERE INTERVENCION");
            }


        }
    }
}
