using System.Collections.Generic;

namespace FormularioDinamico.Model.Contrato
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        IEnumerable<T> ListarTodos();
        T BuscarPorId(T entidade);
    }
}
