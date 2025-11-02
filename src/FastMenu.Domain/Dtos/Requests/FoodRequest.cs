using FastMenu.Domain.Enums;

namespace FastMenu.Domain.Dtos.Requests
{
   public sealed record FoodRequest
   (
       string Name,
       decimal Price,
       string Description,
       int Assessment,
       Category Category
   )
   {
      public string Name { get; set; } = Name;
      public decimal Price { get; set; } = Price;
      public string Description { get; set; } = Description;
      public int Assessment { get; set; } = Assessment;
      public Category Category { get; set; } = Category;
   }
}
