using FoodManager.Catalog.Domain.Entities;
using FoodManager.Catalog.Domain.Filters;
using Mattioli.Configurations.Http;
using Mattioli.Configurations.Repositories;

namespace FoodManager.Catalog.Domain.Interfaces.Repositories;

public interface IFoodRepository : IBaseRepository<FoodEntity>
{
    Task<PagedResult<FoodEntity>> GetFoodsAsync(FoodFiltersBuilder filters, CancellationToken cancellationToken);
}