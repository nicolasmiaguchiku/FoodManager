using FoodManager.Catalog.Application.Mappers;
using FoodManager.Catalog.Domain.Interfaces.Repositories;
using FoodManager.Internal.Shared.Responses;
using FoodManager.Internal.Shared.Services;
using LiteBus.Commands.Abstractions;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands
{
    public sealed class CreateCategoryCommandHandler(
        ICategoryRepository categoryRepository) : ICommandHandler<CreateCategoryCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> HandleAsync(CreateCategoryCommand message, CancellationToken cancellationToken = default)
        {
            var categoryEntity = CategoryMapper.ToEntity(message.CreateCategoryRequest);

            await categoryRepository.AddAsync(categoryEntity, cancellationToken);

            return Result<Guid>.Success(categoryEntity.Id);
        }
    }
}