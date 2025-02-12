using Frutaria.LINQ.Services;

namespace Frutaria.LINQ.Entities
{
    public class CategoriaEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<FrutaEntity> ListFrutas { get; set; }
       
        public void AdicionarFruta(FrutaEntity fruta)
        {
            ListFrutas.Add(fruta);
        }
    }
}
