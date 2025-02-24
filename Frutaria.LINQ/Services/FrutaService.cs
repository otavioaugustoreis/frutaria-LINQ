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

        public async Task<CategoriaEntity> GetCategoriaPorIdAsync(int id)
        {
            return await appDbContext._Categorias.FindAsync(id);
        }
        public async Task<List<FrutaEntity>> GetFrutas() 
        {
            return await appDbContext._Frutas
                .Include(p => p.Categoria)
                .ToListAsync();
        }

        public async  Task<List<FrutaEntity>> GetFrutaAgrupadaPorCategoriaOrdenadaPeloNomeCategoria()
        {
            var frutasAgrupadas = await appDbContext._Frutas
                    .Include(f => f.Categoria)
                    .OrderBy(f => f.Categoria.Nome) 
                    .ToListAsync();

            return frutasAgrupadas;
        }

        public async Task<List<FrutaEntity>> GetFrutaPorCategoriaContendoALetra(CategoriaEntity categoriaEntity, string letra)
        {
            IQueryable<FrutaEntity> queryable = appDbContext._Frutas
                                                             .Where(p => p.Categoria == categoriaEntity
                                                             && p.Nome.Contains(letra));
            return await  queryable.ToListAsync();
        }

        public async  Task<List<FrutaEntity>> GetFrutaPorCategoriaETerminaComLetra(CategoriaEntity categoriaEntity, string letra)
        {
            IQueryable<FrutaEntity> queryable = appDbContext._Frutas
                                                             .Where(p => p.Categoria == categoriaEntity
                                                             && p.Nome.EndsWith(letra));
            return await queryable.ToListAsync();
        }

        public async Task<List<FrutaEntity>> GetFrutaPorComecoDaLetra(string letra)
        {
            IQueryable<FrutaEntity> queryable = appDbContext._Frutas
                                                             .Where(p => p.Nome.StartsWith(letra));
            return await queryable.ToListAsync();
        }

        public async  Task<List<FrutaEntity>> GetFrutasComQuantidadeDeLetra(string letra)
        {
            IQueryable<FrutaEntity> queryable =  appDbContext._Frutas.Where(p => p.Nome.Contains(""));

            return await queryable.ToListAsync();
        }

        public async Task<List<FrutaEntity>> GetFrutasPorCategoria(CategoriaEntity categoriaEntity)
        {
            IQueryable<FrutaEntity> queryable = appDbContext._Frutas
                .Include(p => p.Categoria)    
                .Where(p => p.Categoria == categoriaEntity);                                                 
         
            return await queryable.ToListAsync();
        }
    }
}

