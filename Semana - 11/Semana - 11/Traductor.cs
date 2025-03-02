class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>
    {
        { "time", "tiempo" }, { "person", "persona" }, { "year", "año" }, { "way", "camino" },
        { "day", "día" }, { "thing", "cosa" }, { "man", "hombre" }, { "world", "mundo" },
        { "life", "vida" }, { "hand", "mano" }, { "part", "parte" }, { "child", "niño/a" },
        { "eye", "ojo" }, { "woman", "mujer" }, { "place", "lugar" }, { "work", "trabajo" },
        { "week", "semana" }, { "case", "caso" }, { "point", "punto/tema" }, { "government", "gobierno" },
        { "company", "empresa/compañía" }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una palabra");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TraducirPalabra();
                    break;
                case "2":
                    AgregarPalabra();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void TraducirPalabra()
    {
        Console.Write("Ingrese la palabra: ");
        string palabra = Console.ReadLine().ToLower();

        if (diccionario.ContainsKey(palabra))
        {
            Console.WriteLine("Traducción: " + diccionario[palabra]);
        }
        else if (diccionario.ContainsValue(palabra))
        {
            foreach (var entry in diccionario)
            {
                if (entry.Value == palabra)
                {
                    Console.WriteLine("Traducción: " + entry.Key);
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("Palabra no encontrada en el diccionario.");
        }
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
