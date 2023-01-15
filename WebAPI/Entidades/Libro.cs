using System;

namespace WebAPI.Entidades
{
    public class Libro
    {
        public int id { get; set; }
        public int id_editorial { get; set; }
        public int id_autor { get; set; }
        public string titulo { get; set; }
    }
}
