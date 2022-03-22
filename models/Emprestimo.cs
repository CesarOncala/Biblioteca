using System;

namespace Biblioteca.models
{
    public class Emprestimo
    {
        public int CodObr { get; set; }
        public int NumExe { get; set; }
        public int CodUsu { get; set; }
        public DateTime DatIni { get; set; }
        public DateTime DatFim { get; set; }
        public DateTime? DatDev { get; set; }

        public Obra Obra { get; set; }
        public Usuario Usuario { get; set; }

        public Exemplar Exemplar { get; set; }
    }
}