namespace EJER_2_PAPELERIA
{
    internal class Program
    {
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Papeles");
            Console.WriteLine("2. Utensilios");
            Console.WriteLine("3. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Papeles papel = new Papeles();
                    Console.WriteLine("Código:");
                    papel.Almacenar();
                    papel.Mostrar();
                    break;

                case "2":
                    Utensilios utensilio = new Utensilios();
                    Console.WriteLine("Código:");
                    utensilio.Almacenar();
                    utensilio.Mostrar();
                    break;

                case "3":
                    Console.WriteLine("Saliendo del programa.");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción correcta.");
                    break;
            }

            Console.WriteLine("¿Desea continuar? (si/no): ");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() != "si")
            {
                break;
            }
        }
    }
}

}
