using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Pais
    {
        public int CodPais { get; set; }
        public string NomPais { get; set; }
        public IList<Autor> Autores { get; set; }

    }
}