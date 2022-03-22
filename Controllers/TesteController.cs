

using System.Linq;
using Biblioteca.Db;
using Biblioteca.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers
{
    [ApiController]
    [Route("api/Teste")]
    public class TesteController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public TesteController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {

            var t = this._context.Usuario
            .Include(o => o.TipoUsuario)
            .ToList();

            t.ForEach(o => o.TipoUsuario.Usuarios = null);

            return Ok(t);
        }

        [HttpGet("GetAutores")]
        public IActionResult GetAutores()
            => Ok(this._context.Autor.ToList());

        [HttpGet("GetObra")]
        public IActionResult GetObra()
      => Ok(this._context.Obra.ToList());


        [HttpGet("GetEmprestimos")]
        public IActionResult GetEmprestimos()
             => Ok(this._context.Emprestimo.Include(o=> o.Exemplar).ToList());
    }
}