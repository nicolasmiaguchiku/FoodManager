using FastMenu.Domain.Dtos.Response;
using FastMenu.Domain.Results;
using LiteBus.Queries.Abstractions;

namespace FastMenu.Application.Handlers.Queries;
public sealed class GetFoodQuery : IQuery<Result<IEnumerable<FoodResponse>>>;

