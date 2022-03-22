using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Obra
    {
        public int CodObr { get; set; }
        public string NomObr { get; set; }
        public IList<Exemplar> Exemplares { get; set; }
        public IList<Autoria> Autorias { get; set; }
        public IList<Emprestimo> Emprestimos { get; set; }
    }
}