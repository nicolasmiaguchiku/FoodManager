using FoodManager.Internal.Shared.Http.Catalog.Requests;
using FoodManager.Internal.Shared.Http.Catalog.Responses;
using FoodManager.Internal.Shared.Responses;
using LiteBus.Queries.Abstractions;

namespace FoodManager.Catalog.Application.Output.Queries;

public sealed record GetFoodQuery(GetFoodRequest Foodequest) : IQuery<Result<PagedResult<GetFoodResponse>>>;