using System.Diagnostics;

class Libro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }

    public Libro(string titulo, string autor, string genero) {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
    }
}

class Program {
    static void Main(string[] args) {
        Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();
        
        // Registro de libros
        biblioteca.Add("978-3-16-148410-0", new Libro("Cien años de soledad", "Gabriel García Márquez", "Realismo mágico"));
        biblioteca.Add("978-0-7475-3269-9", new Libro("Harry Potter", "J.K. Rowling", "Fantasía"));

        // Reportería: Visualización de libros
        foreach (var item in biblioteca) {
            Console.WriteLine($"ISBN: {item.Key}, Título: {item.Value.Titulo}, Autor: {item.Value.Autor}");
        }

        // Medición de tiempo de búsqueda
        Stopwatch sw = Stopwatch.StartNew();
        if (biblioteca.ContainsKey("978-3-16-148410-0")) {
            Console.WriteLine("Libro encontrado: " + biblioteca["978-3-16-148410-0"].Titulo);
        }
        sw.Stop();
        Console.WriteLine($"Tiempo de búsqueda: {sw.ElapsedTicks} ticks");
    }
}