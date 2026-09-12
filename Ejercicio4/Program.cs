namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MENU_OPCION_1 = "1) Ver el registro de rutas de la bibliotecva movil";
            const string MENU_OPCION_2 = "2) Ver la meta de periodo";
            const string MENU_OPCION_3 = "3) Ver el rango valido de libros prestados en la ruta";
            const string MENU_OPCION_4 = "4) Salir";
            int opcionUsuario;
            //Condicion 
            do 
            {
                Console.WriteLine("MENU GOBERNACION");
                Console.WriteLine(MENU_OPCION_1);
                Console.WriteLine(MENU_OPCION_2);
                Console.WriteLine(MENU_OPCION_3);
                Console.WriteLine(MENU_OPCION_4);
                Console.Write("Seleccione una opcion:");
                opcionUsuario = int.Parse(Console.ReadLine());
                if (opcionUsuario == 1)
                {
                    Console.WriteLine("Mostrando el registro de rutas...");
                }
                else if (opcionUsuario == 2)
                {
                    Console.WriteLine("La meta del periodo es de 500 libros");
                }
                else if (opcionUsuario == 3)
                {
                    Console.WriteLine("El rago valido es de 1 a 5 libros por persona.");
                }
                else if (opcionUsuario == 4)
                {
                    Console.WriteLine("Saliendo del sistema...");
                }
                else
                {
                    Console.WriteLine("Error: La opcion ingresada no existe");
                }
            } while (opcionUsuario != 4);
            
        }
    }
}
