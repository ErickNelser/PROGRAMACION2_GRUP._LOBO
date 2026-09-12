namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 5, MIN = 50, MAX = 5000, DESC = 1200;
            const double PA = 3000, PJ = 1500;
            int op, tot = 0, d = 0;
            do
            {
                Console.WriteLine("1) Cargar 2)Clas 3) Simul 4)Salir: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    tot = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        int v;
                        do
                        {
                            Console.Write("Prod:");
                            v = int.Parse(Console.ReadLine());

                        }
                        while (v < MIN || v > MAX);
                        tot += v;
                    }
                    d = 1;
                }
                else if (op == 2 && d == 1)
                {
                    int s = tot, j = 0;
                    while (s >= DESC) { s -= DESC; j++; }
                    Console.WriteLine($"Jornadas: {j} sobran: {s}");



                }
            } while (op != 4);

        }
    }
}
