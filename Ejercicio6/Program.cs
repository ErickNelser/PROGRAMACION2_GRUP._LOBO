namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double RESERVA_INICIAL = 30000;
            const double PORCENTAJE_ALERTA = 0.20;
            const double LIMITE_ALERTA = RESERVA_INICIAL * PORCENTAJE_ALERTA;
            double reservaActual = RESERVA_INICIAL;
            int contadorJornadas = 0;
            //Condicion
            while (reservaActual > 0)
            {
                Console.Write("Ingrese el monto fijo entregado a Santa Cruz esta jornada:");
                double entregaDiaria = double.Parse(Console.ReadLine());
                reservaActual = reservaActual - entregaDiaria;
                contadorJornadas ++;
                Console.WriteLine("Saldo restante en la jornada" + contadorJornadas + ":" + reservaActual + "Bs");
                if (reservaActual > 0 && reservaActual < LIMITE_ALERTA)
                { 
                    Console.WriteLine("ALERTA ESPECIAL! La reserva ha bajado del 20 por ciento del total.");

                }
            }
        }
    }
}
