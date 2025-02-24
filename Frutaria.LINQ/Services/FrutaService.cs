using Frutaria.LINQ.Entities;
using Frutaria.LINQ.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Frutaria.LINQ.Services
{
    public class FrutaService : IFrutaService 
    {

         private readonly AppDbContext appDbContext;

        public FrutaService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<List<FrutaEntity>> GetFrutaAgrupadaPorCategoriaOrdenadaPeloNomeCategoria(CategoriaEntity categoriaEntity, string letra)
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutaPorCategoriaContendoALetra(CategoriaEntity categoriaEntity, string letra)
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutaPorCategoriaETerminaComLetra(CategoriaEntity categoriaEntity, string letra)
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutaPorComecoDaLetra(string letra)
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutasComNomeComposto()
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutasComQuantidadeDeLetra(string letra)
        {
            throw new NotImplementedException();
        }

        public Task<List<FrutaEntity>> GetFrutasPorCategoria(CategoriaEntity categoria)
        {
            throw new NotImplementedException();
        }
    }
}
