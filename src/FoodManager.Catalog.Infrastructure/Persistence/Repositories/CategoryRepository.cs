using FoodManager.Catalog.Domain.Entities;
using FoodManager.Catalog.Domain.Interfaces.Repositories;
using FoodManager.Internal.Shared.Repositories;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace FoodManager.Catalog.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository(IMongoDatabase mongoDb, ILogger<CategoryRepository> logger) : BaseRepository<CategoryEntity>(mongoDb, "Categories", logger), ICategoryRepository
    {
        private readonly IMongoCollection<CategoryEntity> _collection = mongoDb.GetCollection<CategoryEntity>("Categories");
    }
}
