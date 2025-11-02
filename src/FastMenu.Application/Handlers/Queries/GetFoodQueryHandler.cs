using FastMenu.Domain.Interfaces;
using FastMenu.Domain.Results;
using LiteBus.Queries.Abstractions;
using FastMenu.Domain.Dtos.Response;
using FastMenu.Domain.Services;

namespace FastMenu.Application.Handlers.Queries
{
    public class GetFoodQueryHandler(
       IFoodRepository foodRepository,
       ICacheService cacheService): IQueryHandler<GetFoodQuery, Result<IEnumerable<FoodResponse>>>
    {
        public async Task<Result<IEnumerable<FoodResponse>>> HandleAsync(GetFoodQuery request, CancellationToken cancellationToken)
        {
            var cached = await cacheService.GetCacheValueAsync<IEnumerable<FoodResponse>>("Foods");

            if (cached is null || !cached.Any())
            {
                var response = await foodRepository.GetFoodAlldAsync(cancellationToken);

                await cacheService.SetCacheValueAsync("Foods", response.Data, TimeSpan.FromDays(7));

                return Result<IEnumerable<FoodResponse>>.Success(response.Data);
            }

            return Result<IEnumerable<FoodResponse>>.Success(cached);
        }
    }
}