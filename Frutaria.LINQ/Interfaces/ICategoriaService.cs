using Frutaria.LINQ.Entities;

namespace Frutaria.LINQ.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaEntity>> ListarTodasCategoriasAsync();

        Task<IEnumerable<CategoriaEntity>> ListarCategoriasComMaisDeXFrutasAsync(int quantidadeMinimaFrutas);

        Task<IEnumerable<CategoriaEntity>> ListarCategoriasSemFrutasAsync();

        Task<IEnumerable<CategoriaEntity>> BuscarCategoriasPorNomeAsync(string termoBusca);

        Task<int> ContarCategoriasAsync();

        Task<IEnumerable<CategoriaEntity>> ListarCategoriasOrdenadasPorNomeAsync(bool ascendente = true);
    }
}
