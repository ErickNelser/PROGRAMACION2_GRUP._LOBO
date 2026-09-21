using System.ComponentModel.Design;

namespace GUERRA_DEL_CHACO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables del estado del fortin
            int agua = 100;
            int municion = 100;
            int moral = 100;
            int dia = 1;
            string decision;

            Console.WriteLine("============================================================");
            Console.WriteLine("           LA DEFENSA HEROICA DEL FORTÍN BOQUERÓN           ");
            Console.WriteLine("============================================================");
            Console.WriteLine("Septiembre de 1932. Eres el Teniente Coronel Manuel Marzana.");
            Console.WriteLine("Tu misión: Resistir el asedio enemigo con tus valientes.");
            Console.WriteLine("Tus decisiones afectarán el Agua, la Munición y la Moral.");
            Console.WriteLine("¡Si alguno de estos recursos llega a 0, el fortín caerá!");

            // Ciclo
            do
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"--- DÍA {dia} DE ASEDIO ---");
                Console.WriteLine($"ESTADO -> Agua: {agua}% | Munición: {municion}% | Moral: {moral}%");
                Console.WriteLine("------------------------------------------------------------");

                //Escenario 1
                if (dia == 1)
                {
                    Console.WriteLine("SITUACIÓN: La artillería enemiga inicia un bombardeo masivo.");
                    Console.WriteLine("1. Responder con fuego nutrido de ametralladoras para intimidar.");
                    Console.WriteLine("2. Ordenar a la tropa ocultarse en las trincheras y no disparar.");
                    Console.Write("Comandante, elija su orden (1 o 2): ");
                    decision = Console.ReadLine();

                    if (decision == "1")
                    {
                        Console.WriteLine("RESULTADO: el enemigo retrocede asustado, pero gastamos muchas balas");
                        municion = municion - 35;
                        moral = moral + 10;
                    }
                    else if (decision == "2")
                    {
                        Console.WriteLine("RESULTADOS: Soprtamos el infierno. Ahorramos balas, pero la tropa esta nerviosa.");
                        moral = moral - 15;
                    }
                    else
                    {
                        Console.WriteLine("RESULTADO: La falta de una orden clara causa caos en la filas.");
                    }
                }

                //Escenario 2
                else if (dia == 2)
                {
                    Console.WriteLine("SITUACIÓN: Francotiradores enemigos vigilan nuestra única aguada (pozo).");
                    Console.WriteLine("1. Enviar un pelotón arriesgando sus vidas para traer agua.");
                    Console.WriteLine("2. Racionar el agua al extremo (un sorbo por soldado al día).");
                    Console.Write("Comandante, elija su orden (1 o 2): ");
                    decision = Console.ReadLine();

                    if (decision == "1")
                    {
                        Console.WriteLine("RESULTADO: traen agua. pero perdemos valiosos soldados. La moral baja");
                        agua = agua + 30;
                        moral = moral - 25;

                    }
                    else if (decision == "2")
                    {
                        Console.WriteLine("RESULTADO: La deshidratacion es severa. Evitamos bajas por disparos, perola sed enloquese");
                        agua = agua - 40;
                        moral = moral - 10;

                    }
                    else
                    {
                        Console.WriteLine("RESULTADO: Indecision. No conseguimos agua y el sol castiga sin piedad");
                        agua = agua - 50;
                    }

                }
                // Escenario 3
                else if (dia == 3)
                {
                    Console.WriteLine("SITUACIÓN: ¡Ataque masivo de infantería frontal! Se acercan a las trincheras.");
                    Console.WriteLine("1. Fuego a discreción y lanzar granadas.");
                    Console.WriteLine("2. Esperar a que estén a 50 metros y contraatacar con bayoneta calada.");
                    Console.Write("Comandante, elija su orden (1 o 2): ");
                    decision = Console.ReadLine();

                    if (decision == "1")
                    {
                        Console.WriteLine("RESULTADO: Detenemos el avance, pero agotamos nuestros cargadores");
                        municion = municion - 50;
                    }
                    else if (decision == "2")
                    {
                        Console.WriteLine("RESULTADO: Un ataque curpo a cuerpo heroico, rechazamos el ataque ahorrando balas");
                        moral = moral + 20;
                        municion = municion - 15;
                        agua = agua - 15;
                    }
                    else
                    {
                        Console.WriteLine("RESULTADO: El enemigo penetra la primera linea por nuestra lentitud");
                        moral = moral - 40;
                        agua = agua - 30;
                    }



                }

                // Verificamos de inmediato si la decision causo la derrota
                if (agua <= 0)
                {
                    Console.WriteLine("DERROTA: La tropa ha colapsado por la deshidratacion. Boquerón ha caido");

                }
                else if (municion <= 0)
                {
                    Console.WriteLine("DERROTA: Nos quedamos sin municion. Los enemigos han tomado las trincheras");
                }
                else if (moral <= 0)

                {
                    Console.WriteLine("DERROTA: Los soldados, desesperados, han levandato la bandera blanca ");
                }

                // Pasar al siguiente dia
                dia = dia + 1;

            } while (dia <= 3 && agua > 0 && municion > 0 && moral > 0);

            if (agua > 0 && municion > 0 && moral > 0)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("  ¡VICTORIA ESTRATÉGICA! HAS SOBREVIVIDO LOS 3 DÍAS CRÍTICOS");
                Console.WriteLine("============================================================");
                Console.WriteLine("Tu liderazgo mantuvo Boquerón en pie y pasó a la historia.");
                Console.WriteLine($"ESTADO FINAL -> Agua: {agua}% | Munición: {municion}% | Moral: {moral}%");
                Console.WriteLine("============================================================");


            }
            Console.WriteLine("Presione ENTER para finalizar...");
            Console.ReadLine();




        }
    }
}
    


    

    

