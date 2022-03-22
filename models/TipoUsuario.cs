using System.Collections.Generic;

namespace Biblioteca.models
{
    public class TipoUsuario
    {
        public int TipUsu { get; set; }
        public string DesTipUsu { get; set; }

        public IList<Usuario> Usuarios { get; set; }
    }
}