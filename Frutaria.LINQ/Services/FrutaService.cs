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

        public async Task<List<FrutaEntity>> getAll() => await appDbContext._Frutas.ToListAsync();
    }
}
