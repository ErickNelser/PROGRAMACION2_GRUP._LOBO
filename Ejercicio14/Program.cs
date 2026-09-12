namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante
            const int TOTAL_ZONAS = 2;
            const int TOTAL_DIAS = 4;
            const double UMBRAL_INSPECCION = 180.0;
            double totalGeneralGuaqui = 0;
            Console.WriteLine("REPORTE DE INSPECCION: FERROCARRIL GUAQUI (LA PAZ)");
            //Condicion
            for (int zona = 1; zona <= TOTAL_ZONAS; zona++)
            {
                Console.WriteLine("Registrando datos para zona" + zona);
                //Requisito
                double subtotalZona = 0;
                //Condicion
                for(int dia = 1; dia <= TOTAL_DIAS; dia++)
                {
                    Console.Write("Ingrese kilometros de via inspeccionados en el dia " + dia + ":");
                    double kilometros = double.Parse(Console.ReadLine());
                    subtotalZona = subtotalZona + kilometros;
                }
                //Requisitos
                totalGeneralGuaqui = totalGeneralGuaqui + subtotalZona;
                Console.WriteLine("Subtotal acumulado en la zona" + zona + ":" + subtotalZona + "km");
                if (subtotalZona >= UMBRAL_INSPECCION)
                {
                    Console.WriteLine("Clasificacion de l azona: INSPECCION ALTA");

                }
                else
                {
                    Console.WriteLine("Clasisficacion de la zona: INSPECCION BAJA");
                }

            }
            Console.WriteLine("===TOTAL GENERAL DE INSPECCION EN GUAQUI===" + totalGeneralGuaqui + "km");
        }
    }
}
