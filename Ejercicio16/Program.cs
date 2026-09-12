namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int OPS = 6, L1 = 3000, L2 = 1200; //Constantes
            const double T1 = 0.20, T2 = 0.10;
            double tot = 0; int obs = 0;
            for (int i = 1; i <= OPS; i++)
            {
                Console.Write("Monto:");
                double m = double.Parse(Console.ReadLine()), inc = 0;
                if (m >= L1) inc = m * T1;
                else if (m >= L2) inc = m * T2;
                else obs++;
                tot += inc;

            }
            Console.WriteLine($"Total inc: {tot}, Obs: {obs}");
        }
    }
}
