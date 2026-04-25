namespace SistemaBiblioteca.Backend
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Anio { get; set; }
        public bool EstaPrestado { get; set; }

        public Libro(string titulo, string autor, string editorial, int anio)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Anio = anio;
            EstaPrestado = false; 
        }
    }
}
