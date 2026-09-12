namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int INI = 2016, ANIOS = 15;
            int bar = 0, hit = 0;
            for (int a = 1; a <= ANIOS; a++)
            {
                Console.Write("Barrios" + ((INI - 1) + a) + ";");
                bar += int.Parse(Console.ReadLine());
                if (a % 5 == 0)
                {
                    Console.WriteLine("Acto? (1 Si, 2 No):");
                    if (int.Parse(Console.ReadLine()) == 1) hit++;
                }
                
            }
            Console.WriteLine($"Barrios: {bar}, Hitos: {hit}");
        }
    }
}
