using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Exemplar
    {
        public int CodObr { get; set; }
        public int NumExe { get; set; }
        public int CodEdi { get; set; }
        public float ValorExe { get; set; }

        public Obra Obra { get; set; }

        public Editora Editora { get; set; }

        public IList<Emprestimo> Emprestimos { get; set; }
    }
}