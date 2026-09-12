namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CENT = -1; const double G = 1500, M = 500;
            int cant = 0; double sum = 0, val;
            Console.Write("Hect (-1 fin):");
            val = double.Parse(Console.ReadLine());
            while (val != CENT)
            {
                cant++; sum += val;
                Console.Write("Hcet (-1 fin):");
                val = double.Parse(Console.ReadLine());

            }
            if (cant == 0) Console.WriteLine("Vacio");
            else
            {
                double p = sum / cant;
                if (p >= G) Console.WriteLine("ALTA");
                else if (p >= M) Console.WriteLine("MODERADA");
                else Console.WriteLine("LEVE");
            }
        }
    }
}
