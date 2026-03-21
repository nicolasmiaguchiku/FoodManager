using FoodManager.Catalog.Domain.Entities;
using FoodManager.Catalog.Domain.Filters;
using FoodManager.Internal.Shared.Repositories;
using FoodManager.Internal.Shared.Responses;

namespace FoodManager.Catalog.Domain.Interfaces.Repositories;

public interface IFoodRepository : IBaseRepository<FoodEntity>
{
    Task<PagedResult<FoodEntity>> GetFoodsAsync(FoodFiltersBuilder filters, CancellationToken cancellationToken);
}