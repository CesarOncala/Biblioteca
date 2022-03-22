using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Autor
    {
        public int CodAut { get; set; }
        public string NomAut { get; set; }
        public int CodPai { get; set; }
        public Pais Pais { get; set; }

        public IList<Autoria> Autorias { get; set; }

    }
}