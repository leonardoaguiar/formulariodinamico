using System.Collections.Generic;
using System.Data.Entity;
using FormularioDinamico.Model;

namespace FormularioDinamico.RepositorioEF
{
    public class Inicializador : DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var tipoDeCampo = new List<TipoDeCampo>
            {
                new TipoDeCampo { Tipo = "Texto" },
                new TipoDeCampo { Tipo = "Lista" },
                new TipoDeCampo { Tipo = "Checkbox" },
                new TipoDeCampo { Tipo = "Área Texto" }
            };

            tipoDeCampo.ForEach(s => contexto.TiposDeCampo.Add(s));
            contexto.SaveChanges();
        }
    }
}
