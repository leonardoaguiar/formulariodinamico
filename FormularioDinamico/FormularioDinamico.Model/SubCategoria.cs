using System.Collections.Generic;

namespace FormularioDinamico.Model
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Slug { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Campo> Campos { get; set; }
    }
}
