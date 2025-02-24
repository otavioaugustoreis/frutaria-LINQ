using Frutaria.LINQ.Entities;

namespace Frutaria.LINQ.Interfaces
{
    public interface  IFrutaService
    {
        public Task<List<FrutaEntity>> GetFrutasPorCategoria(CategoriaEntity categoria);
        public Task<List<FrutaEntity>> GetFrutaPorComecoDaLetra(string letra);
        public Task<List<FrutaEntity>> GetFrutasComQuantidadeDeLetra(string letra);
        public Task<List<FrutaEntity>> GetFrutasComNomeComposto();
        public Task<List<FrutaEntity>> GetFrutaPorCategoriaETerminaComLetra(CategoriaEntity categoriaEntity,string letra);
        public Task<List<FrutaEntity>> GetFrutaPorCategoriaContendoALetra(CategoriaEntity categoriaEntity, string letra);
        public Task<List<FrutaEntity>> GetFrutaAgrupadaPorCategoriaOrdenadaPeloNomeCategoria(CategoriaEntity categoriaEntity, string letra);
    }
}
