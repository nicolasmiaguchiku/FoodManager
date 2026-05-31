using FoodManager.Catalog.Domain.ValueObjects;

namespace FoodManager.Catalog.Domain.Entities
{
    public class FoodEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string Tenant { get; set; } = string.Empty;
        public int Assessment { get; set; }
        public Guid CategoryId { get; set; }
        public FoodImage? FoodImage { get; set; } = default!;

        public FoodEntity SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public FoodEntity SetName(string name)
        {
            Name = name;
            return this;
        }

        public FoodEntity SetPrice(double price)
        {
            Price = price;
            return this;
        }

        public FoodEntity SetDescription(string description)
        {
            Description = description;
            return this;
        }
        public FoodEntity SetAssessment(int assessment)
        {
            Assessment = assessment;
            return this;
        }

        public FoodEntity SetCategory(Guid category)
        {
            CategoryId = category;
            return this;
        }

        public FoodEntity SetTenant(string tenant)
        {
            Tenant = tenant;
            return this;
        }

        public FoodEntity SetImageFile(FoodImage foodImage)
        {
            FoodImage = foodImage;
            return this;
        }

        public Builder ToBuilder()
        {
            return new Builder
            {
                Name = Name,
                Price = Price,
                Description = Description,
                Assessment = Assessment,
                CategoryId = CategoryId,
                Tenant = Tenant,
                FoodImage = FoodImage
            };
        }

        public class Builder
        {
            public Guid Id { get; set; }
            public string? Name { get; set; }
            public double Price { get; set; }
            public string? Description { get; set; }
            public string? Tenant { get; set; }
            public int Assessment { get; set; }
            public Guid CategoryId { get; set; }
            public FoodImage? FoodImage { get; set; } = default!;

            public static Builder Create() => new();

            public Builder SetId(Guid id) { Id = id; return this; }
            public Builder SetName(string name) { Name = name; return this; }
            public Builder SetPrice(double price) { Price = price; return this; }
            public Builder SetDescription(string description) { Description = description; return this; }
            public Builder SetTenant(string tenant) { Tenant = tenant; return this; }
            public Builder SetAssessment(int assesment) { Assessment = assesment; return this; }
            public Builder SetCategory(Guid categoryId) { CategoryId = categoryId; return this; }
            public Builder SetImageFile(FoodImage foodImage) { FoodImage = foodImage; return this; }

            public FoodEntity Build()
            {
                return new FoodEntity
                {
                    Id = Id,
                    Name = Name,
                    Price = Price,
                    Description = Description,
                    Assessment = Assessment,
                    CategoryId = CategoryId,
                    Tenant = Tenant ?? string.Empty,
                    FoodImage = FoodImage
                };
            }
        }
    }
}