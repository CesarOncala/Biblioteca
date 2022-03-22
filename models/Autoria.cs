using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Autoria
    {
        public int CodObr { get; set; }
        public int CodAut { get; set; }

        public Obra Obra { get; set; }
        public Autor Autor { get; set; }
    }
}