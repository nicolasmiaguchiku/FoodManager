using FastMenu.Domain.Dtos.Requests;
using FastMenu.Domain.Dtos.Response;
using FastMenu.Domain.Entities;
using FastMenu.Domain.Interfaces;
using FastMenu.Domain.Results;
using FastMenu.Infrastructure.Mappers;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace FastMenu.Infrastructure.Persistence.Repositories
{
    public class FoodRepository(IMongoDatabase mongoDb) : IFoodRepository
    {
        private readonly IMongoCollection<FoodEntity> _collection = mongoDb.GetCollection<FoodEntity>("Foods");

        public async Task<Result<FoodResponse>> AddFoodAsync(FoodRequest foodRequest, CancellationToken cancellationToken)
        {
            var foodEntity = foodRequest.ToEntity();

            await _collection.InsertOneAsync(foodEntity, cancellationToken: cancellationToken);

            var response = foodEntity.ToResponse();

            return Result<FoodResponse>.Success(response);
        }

        public async Task<Result<IEnumerable<FoodResponse>>> GetFoodAlldAsync(CancellationToken cancellationToken)
        {
            var foodEntities = await _collection.FindAsync(FilterDefinition<FoodEntity>.Empty, cancellationToken: cancellationToken);

            var listFood = await foodEntities.ToListAsync(cancellationToken);

            if (listFood == null || listFood!.Count == 0)
            {
                return Result<IEnumerable<FoodResponse>>.Failure(new Error("Nenhuma comida encontrada", "lista vazia"));
            }
            else
            {
                var foodDomains = listFood.Select(x => x.ToResponse());

                return Result<IEnumerable<FoodResponse>>.Success(foodDomains);
            }
        }
    }
}
