using FoodManager.Catalog.Application.Input.Requests;
using FoodManager.Catalog.Application.Output.Response;
using Mattioli.Configurations.Models;
using FoodManager.Catalog.Domain.Filters;
using LiteBus.Queries.Abstractions;
using Mattioli.Configurations.Http;

namespace FoodManager.Catalog.Application.Output.Queries;

public sealed record GetFoodQuery(GetFoodRequest Foodequest) : IQuery<Result<PagedResult<GetFoodResponse>>>;