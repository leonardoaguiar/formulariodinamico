using System.Collections.Generic;

namespace FormularioDinamico.Model
{
    public class Campo
    {
        public int Id { get; set; }
        public int Ordem { get; set; }
        public ICollection<TipoDeCampo> TipoDeCampos { get; set; }
        public ICollection<ItemDoCampo> ItemDoCampos { get; set; }
    }
}
