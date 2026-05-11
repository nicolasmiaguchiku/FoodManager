using FoodManager.Catalog.Domain.Entities;
using FoodManager.Internal.Shared.Repositories;

namespace FoodManager.Catalog.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IBaseRepository<CategoryEntity>
    {
    }
}
