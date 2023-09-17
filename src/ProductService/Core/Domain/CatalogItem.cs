namespace CatalogService.Core.Domain
{
    public class CatalogItem
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool isDeleted { get; set; }
    }
}
