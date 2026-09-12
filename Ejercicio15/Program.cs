namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COD = 2009, MAX = 3; //Constantes
            int intR = MAX, ok = 0;
            //Condicion
            do
            {
                Console.Write("Codigo:");
                if (int.Parse(Console.ReadLine()) == COD)
                {
                    ok = 1;
                    Console.Write("Permiso (1 Cons, 2 Edic):");
                    if (int.Parse(Console.ReadLine()) == 1) Console.WriteLine("CONSULTA");
                    else Console.WriteLine("EDICION");
                }
                else
                {
                    intR--;
                    if (intR > 0) Console.WriteLine("Quedan:" + intR);
                    else Console.WriteLine("BLOQUEADO");

                }

            } while (intR > 0 && ok == 0);
        }
    }
}
