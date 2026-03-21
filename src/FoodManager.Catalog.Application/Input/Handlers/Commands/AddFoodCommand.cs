using FoodManager.Internal.Shared.Http.Catalog.Requests;
using FoodManager.Internal.Shared.Http.Catalog.Responses;
using FoodManager.Internal.Shared.Responses;
using LiteBus.Commands.Abstractions;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public record AddFoodCommand(AddFoodRequest FoodRequest) : ICommand<Result<GetFoodResponse>>;