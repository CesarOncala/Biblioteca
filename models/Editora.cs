using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Editora
    {
        public int CodEdi { get; set; }
        public string NomEdi { get; set; }

        public IList<Exemplar> Exemplares { get; set; }
    }
}