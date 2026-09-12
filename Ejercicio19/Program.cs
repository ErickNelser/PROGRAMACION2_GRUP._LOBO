namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int META = 3000, P1 = 150, P2 = 75;
            int rec = 3, pts = 0, ab = 0;

            do
            {
                if (rec == 1) Console.WriteLine("Queda un recurso");
                Console.Write("1)Int 2)Prev 3)Retirarse:");
                int op = int.Parse(Console.ReadLine());
                if (op == 1) { rec--; pts += P1; }
                else if (op == 2) pts += P2;
                else if (op == 3) ab = 1;
            }
            while (rec > 0 && pts < META && ab == 0);
            if (pts >= 2000) Console.WriteLine("GRAVE");
            else if (pts >= 1000) Console.WriteLine("MODERADO");
            else Console.WriteLine("LEVE");

        }
    }
}
