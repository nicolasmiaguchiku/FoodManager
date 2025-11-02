using FastMenu.Domain.Results;
using FastMenu.Domain.Dtos.Response;
using FastMenu.Domain.Dtos.Requests;

namespace FastMenu.Domain.Interfaces
{
   public interface IFoodRepository
   {
      Task<Result<FoodResponse>> AddFoodAsync(FoodRequest foodRequest, CancellationToken cancellationToken);
      Task<Result<IEnumerable<FoodResponse>>> GetFoodAlldAsync(CancellationToken cancellationToken);
   }
}
