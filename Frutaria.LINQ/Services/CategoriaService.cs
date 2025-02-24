using Frutaria.LINQ.Entities;
using Frutaria.LINQ.Interfaces;

namespace Frutaria.LINQ.Services
{
    public class CategoriaService : ICategoriaService 
    {

        private readonly AppDbContext appDbContext;

        public CategoriaService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<IEnumerable<CategoriaEntity>> BuscarCategoriasPorNomeAsync(string termoBusca)
        {
            throw new NotImplementedException();
        }

        public Task<int> ContarCategoriasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> ListarCategoriasComMaisDeXFrutasAsync(int quantidadeMinimaFrutas)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> ListarCategoriasOrdenadasPorNomeAsync(bool ascendente = true)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> ListarCategoriasSemFrutasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> ListarTodasCategoriasAsync()
        {
            throw new NotImplementedException();
        }
    }
}
