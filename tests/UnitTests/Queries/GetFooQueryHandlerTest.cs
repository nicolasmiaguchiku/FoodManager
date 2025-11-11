using AutoFixture;
using FoodManager.Application.Output.Queries;
using FoodManager.Domain.Interfaces.Repositories;
using FoodManager.Domain.Interfaces.Services;
using Moq;

namespace UnitTests.Queries
{
    public class GetFooQueryHandlerTest
    {
        private readonly Mock<IFoodRepository> _foodRepositoryMock = new();
        private readonly Mock<ICacheService> _cacheServiceMock = new();
        private readonly Fixture _fixture = new();
        private readonly GetFoodQueryHandler _handler;

        public GetFooQueryHandlerTest()
        {
            _handler = new GetFoodQueryHandler(_foodRepositoryMock.Object, _cacheServiceMock.Object);
        }
    }
}
