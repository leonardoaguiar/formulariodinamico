using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FormularioDinamico.Model;

namespace FormularioDinamico.RepositorioEF
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DbFormularioDinamico") { }

        public DbSet<Campo> Campos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemDoCampo> ItensDoCampo { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<TipoDeCampo> TiposDeCampo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
