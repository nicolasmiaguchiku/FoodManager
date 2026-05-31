using FoodManager.Catalog.Domain.Entities;
using FoodManager.Internal.Shared.Http.Catalog.Requests;

namespace FoodManager.Catalog.Application.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryEntity ToEntity(this CreateCategoryRequest request)
        {
            return new CategoryEntity
            {
                Id = Guid.NewGuid(),
                CategoryName = request.CategoryName,
                Description = request.Description,
                IsActive = true
            };
        }
    }
}