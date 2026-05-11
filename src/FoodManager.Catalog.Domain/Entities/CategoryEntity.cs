namespace FoodManager.Catalog.Domain.Entities
{
    public class CategoryEntity
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = string.Empty;
        public string Tenant { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}