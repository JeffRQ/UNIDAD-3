class Program
{
    static void Main()
    {
        // Generar 500 pacientes
        HashSet<string> pacientes = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            pacientes.Add($"Paciente {i}");
        }

        // Generar 75 pacientes vacunados con Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        Random rnd = new Random();
        while (vacunadosPfizer.Count < 75)
        {
            vacunadosPfizer.Add($"Paciente {rnd.Next(1, 501)}");
        }

        // Generar 75 pacientes vacunados con AstraZeneca
        HashSet<string> vacunadosAstrazeneca = new HashSet<string>();
        while (vacunadosAstrazeneca.Count < 75)
        {
            string paciente = $"Paciente {rnd.Next(1, 501)}";
            if (!vacunadosPfizer.Contains(paciente)) // Evita duplicados
            {
                vacunadosAstrazeneca.Add(paciente);
            }
        }

        // Pacientes con ambas vacunas (intersección de ambos conjuntos)
        HashSet<string> vacunadosAmbas = new HashSet<string>(vacunadosPfizer.Intersect(vacunadosAstrazeneca));

        // Pacientes que no se han vacunado (diferencia con ambos conjuntos)
        HashSet<string> noVacunados = new HashSet<string>(pacientes.Except(vacunadosPfizer).Except(vacunadosAstrazeneca));

        // Pacientes vacunados con ambas dosis
        HashSet<string> vacunadosDosDosis = new HashSet<string>(vacunadosPfizer.Union(vacunadosAstrazeneca));

        // Pacientes vacunados solo con Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer.Except(vacunadosAstrazeneca));

        // Pacientes vacunados solo con AstraZeneca
        HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca.Except(vacunadosPfizer));

        // Imprimir resultados
        Console.WriteLine("Pacientes que no se han vacunado: " + noVacunados.Count);
        Console.WriteLine("Pacientes que han recibido ambas vacunas: " + vacunadosAmbas.Count);
        Console.WriteLine("Pacientes vacunados solo con Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Pacientes vacunados solo con AstraZeneca: " + soloAstrazeneca.Count);
    }
}
