using System.Collections.Generic;

namespace Biblioteca.models
{
    public class Usuario
    {
        public int CodUsu { get; set; }
        public string NomUsu { get; set; }

        public char SexoUsu { get; set; }

        public int TipUsu { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
        public IList<Emprestimo> Emprestimos { get; set; }
    }
}