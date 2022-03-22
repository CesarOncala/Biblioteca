using Biblioteca.models;
using Biblioteca.models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Autoria> Autoria { get; set; }

        public DbSet<Editora> Editora { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }

        public DbSet<Exemplar> Exemplar { get; set; }

        public DbSet<Obra> Obra { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutoriaMap());
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());
            modelBuilder.ApplyConfiguration(new ExemplarMap());
            modelBuilder.ApplyConfiguration(new ObraMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PaisMap());
            modelBuilder.ApplyConfiguration(new TipoUsuarioMap());
            modelBuilder.ApplyConfiguration(new EditoraMap());
        }

    }
}