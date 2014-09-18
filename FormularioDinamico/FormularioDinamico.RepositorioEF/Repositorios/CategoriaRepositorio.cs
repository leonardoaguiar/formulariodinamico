using System.Collections.Generic;
using System.Linq;
using FormularioDinamico.Model;
using FormularioDinamico.Model.Contrato;

namespace FormularioDinamico.RepositorioEF.Repositorios
{
    public class CategoriaRepositorio : IRepositorio<Categoria>
    {
        private readonly Contexto _contexto;

        public CategoriaRepositorio()
        {
            _contexto = new Contexto();
        }

        public void Salvar(Categoria entidade)
        {
            if (entidade.Id > 0)
            {
                var categoria = _contexto.Categorias.First(x => x.Id == entidade.Id);
                categoria.Descricao = entidade.Descricao;
                categoria.Slug = entidade.Slug;
                categoria.SubCategorias = entidade.SubCategorias;
            }
            else
            {
                _contexto.Categorias.Add(entidade);
            }

            _contexto.SaveChanges();
        }

        public void Excluir(Categoria entidade)
        {
            var alunoExcluir = _contexto.Categorias.First(x => x.Id == entidade.Id);
            _contexto.Set<Categoria>().Remove(alunoExcluir);
            _contexto.SaveChanges();
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            return _contexto.Categorias;
        }

        public Categoria BuscarPorId(Categoria entidade)
        {
            return _contexto.Categorias.First(x => x.Id == entidade.Id);
        }
    }
}
