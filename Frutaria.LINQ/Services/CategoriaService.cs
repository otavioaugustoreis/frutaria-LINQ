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
    }
}
