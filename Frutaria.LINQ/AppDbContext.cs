using Frutaria.LINQ.Entities;
using Microsoft.EntityFrameworkCore;

namespace Frutaria.LINQ
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FrutaEntity> _Frutas { get; set; }
        public DbSet<CategoriaEntity> _Categorias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FrutaEntity>().HasKey(p => p.Id);
            modelBuilder.Entity<CategoriaEntity>().HasKey(p => p.Id);

            modelBuilder.Entity<FrutaEntity>()
                .HasOne(p => p.Categoria)
                .WithMany(p => p.ListFrutas)
                .HasForeignKey(p => p.fkCategoria);

            modelBuilder.Entity<CategoriaEntity>().HasData(
                new CategoriaEntity { Id = 1, Nome = "Cítricas" },
                new CategoriaEntity { Id = 2, Nome = "Tropicais" },
                new CategoriaEntity { Id = 3, Nome = "Rosáceas" },
                new CategoriaEntity { Id = 4, Nome = "Musáceas" }
                );

            modelBuilder.Entity<FrutaEntity>().HasData(
                new FrutaEntity { Id = 1, Nome = "Laranja", fkCategoria = 1 },
                new FrutaEntity { Id = 2, Nome = "Limão", fkCategoria = 1 },
                new FrutaEntity { Id = 3, Nome = "Abacaxi", fkCategoria = 2 },
                new FrutaEntity { Id = 4, Nome = "Manga", fkCategoria = 2 },
                new FrutaEntity { Id = 5, Nome = "Maçã", fkCategoria = 3 },
                new FrutaEntity { Id = 6, Nome = "Pera", fkCategoria = 3 },
                new FrutaEntity { Id = 7, Nome = "Morango", fkCategoria = 3 },
                new FrutaEntity { Id = 8, Nome = "Banana", fkCategoria = 4 },
                new FrutaEntity { Id = 9, Nome = "Melancia", fkCategoria = 2 },
                new FrutaEntity { Id = 10, Nome = "Uva", fkCategoria = 3 }
            );
        }
    }
}

