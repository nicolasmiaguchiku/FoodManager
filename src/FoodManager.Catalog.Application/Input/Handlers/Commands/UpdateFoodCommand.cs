using FoodManager.Internal.Shared.Responses;
using LiteBus.Commands.Abstractions;
using FoodManager.Internal.Shared.Http.Catalog.Requests;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public sealed record UpdateFoodCommand(UpdateFoodRequest UpdateFoodRequest) : ICommand<Result<bool>>;