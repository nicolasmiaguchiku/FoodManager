using FoodManager.Internal.Shared.Http.Catalog.Requests;
using FoodManager.Internal.Shared.Responses;
using LiteBus.Commands.Abstractions;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public sealed record CreateCategoryCommand(CreateCategoryRequest CreateCategoryRequest) : ICommand<Result<Guid>>;