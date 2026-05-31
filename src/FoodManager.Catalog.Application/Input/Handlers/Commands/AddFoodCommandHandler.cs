using FoodManager.Catalog.Application.Mappers;
using FoodManager.Catalog.Domain.Interfaces.Repositories;
using FoodManager.Internal.Shared.Responses;
using FoodManager.Internal.Shared.Services;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.Logging;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands
{
    public sealed class AddFoodCommandHandler(
        IFoodRepository _repository,
        ILogger<AddFoodCommandHandler> _logger) : ICommandHandler<AddFoodCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> HandleAsync(AddFoodCommand request, CancellationToken cancellationToken = default)
        {
            var result = request.FoodRequest.ToEntity();

            await _repository.AddAsync(result, cancellationToken);

            _logger.LogInformation("FoodName {FoodName} add successfully", result.Name);

            return Result<Guid>.Success(result.Id);
        }
    }
}