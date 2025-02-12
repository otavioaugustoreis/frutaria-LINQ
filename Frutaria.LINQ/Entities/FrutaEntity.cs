namespace Frutaria.LINQ.Entities
{
    public class FrutaEntity
    {
        public int  Id { get; set; }
        public string  Nome { get; set; }
        public int fkCategoria { get; set; }
        public CategoriaEntity Categoria { get; set; }
    }
}
