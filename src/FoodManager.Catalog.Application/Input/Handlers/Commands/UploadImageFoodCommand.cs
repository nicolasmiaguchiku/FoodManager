using FoodManager.Catalog.Application.Input.Requests;
using LiteBus.Commands.Abstractions;
using FoodManager.Internal.Shared.Responses;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public sealed record UploadImageFoodCommand(Guid Id, UploadImageFoodRequest Request) : ICommand<Result<string>>;