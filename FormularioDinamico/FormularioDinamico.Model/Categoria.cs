using System.Collections.Generic;

namespace FormularioDinamico.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Slug { get; set; }
        public ICollection<SubCategoria> SubCategorias { get; set; }
    }
}
