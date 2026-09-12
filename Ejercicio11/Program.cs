namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int META_PERIODO = 1000;
            int opcionPrincipal;
            int totalRegistrosUrgentes = 0;
            //Condicion
            do
            {
                Console.WriteLine("ARCHIVO Y BIBLIOTECA NACIONAL");
                Console.WriteLine("1) Registrar documento");
                Console.WriteLine("2) Cosultar meta");
                Console.WriteLine("3) Salir");
                Console.Write("Seleccione: ");
                opcionPrincipal = int.Parse(Console.ReadLine());
                if (opcionPrincipal == 1)
                {
                    Console.Write("Ingrese zona (1 = zona norte.2 = zona sur): ");
                    int zona = int.Parse(Console.ReadLine());

                    if (zona == 1 || zona == 2)
                    {
                        Console.Write("El registro es urgente? (1 = si, 2 = no):");
                        int urgente = int.Parse(Console.ReadLine());

                        if (urgente == 1)
                        {
                            Console.WriteLine("DOCUMENTO URGENTE guardado en la zona" + zona + ".");
                            totalRegistrosUrgentes++;
                        }
                        else if (urgente == 2)
                        {
                            Console.WriteLine("Documento regular guardado en la zona" + zona + ".");
                        }
                        else
                        {
                            Console.WriteLine("Opcion de urgencia Rechazada. Volviendo al menu.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("zona rechazada. Volviendo al menu");
                    }



                }
                else if (opcionPrincipal == 2)
                {
                    Console.WriteLine("La meta para el periodo actual es de " + META_PERIODO + " transcripciones.");
                }
                else if (opcionPrincipal != 3) ;
                {
                    Console.WriteLine("Comando rechazado.");
                }

            } 
            while (opcionPrincipal != 3) ;
            Console.WriteLine("Cerrando sistema. Total de registrados urgentes durante la secion:" + totalRegistrosUrgentes);

            
            

        }
    }
}
