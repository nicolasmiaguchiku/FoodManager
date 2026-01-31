using LiteBus.Commands.Abstractions;
using Mattioli.Configurations.Models;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands
{
    public sealed class UploadFoodImageCommandHandler() : ICommandHandler<UploadFoodImageCommand, Result>
    {
        public Task<Result> HandleAsync(UploadFoodImageCommand message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}