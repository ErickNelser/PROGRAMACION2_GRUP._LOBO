namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int TOTAL_PARCELAS = 4;
            double ahorroMaximo = 0;
            double ahorroMinimo = 0;
            int idParcelaMax = 0;
            int idParcelaMin = 0;
            //Condicion 
            for (int i = 1; i <= TOTAL_PARCELAS; i++)
            {
                Console.Write("Ingrse litros ahorrados en la parcela" + i + ":");
                double litros = double.Parse(Console.ReadLine());
                if (i == 1)
                {
                    ahorroMaximo = litros;
                    ahorroMinimo = litros;
                    idParcelaMax = i;
                    idParcelaMin = i;
                }
                else
                {
                    if (litros > ahorroMaximo)
                    {
                        ahorroMaximo = litros;
                        idParcelaMax = i;
                    }
                    if (litros < ahorroMinimo)
                    {
                        ahorroMinimo = litros;
                        idParcelaMin = i;
                    }
                }
            }
            Console.WriteLine("El mayor ahorro fue de: " + ahorroMaximo + " litros en la parcela " + idParcelaMax);
            Console.WriteLine("El menor ahorro fue de: " + ahorroMinimo + " litros en la parcela " + idParcelaMin);
        }
    }
}