using AutoFixture;
using FluentAssertions;
using FoodManager.Catalog.Application.Input.Handlers.Commands;
using FoodManager.Catalog.Domain.Entities;
using FoodManager.Catalog.Domain.Interfaces.Repositories;
using FoodManager.Internal.Shared.Http.Auth.Models;
using FoodManager.Internal.Shared.Http.Catalog.Requests;
using FoodManager.Internal.Shared.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace UnitTests.Commands
{
    public class AddFoodCommandHandlerTest
    {
        private readonly Mock<IFoodRepository> _foodReposiroryMock = new();
        private readonly Mock<ILogger<AddFoodCommandHandler>> _loggerServiceMock = new();
        private readonly Mock<ITenantProvider> _tenantProviderMock = new();
        private readonly Fixture _fixture = new();
        public readonly AddFoodCommandHandler _handler;

        public AddFoodCommandHandlerTest()
        {
            _handler = new(
                _foodReposiroryMock.Object,
                _loggerServiceMock.Object,
                _tenantProviderMock.Object);
        }

        [Fact]
        public async Task WhenAddNewFoodAndRequestIsValidThenFoodShouldBeInsertAsync()
        {
            //Arrange
            var request = _fixture.Create<AddFoodRequest>();
            var command = new AddFoodCommand(request);

            _tenantProviderMock
                .Setup(x => x.GetTenant())
                .Returns(new Tenant("Tenant-Test"));

            //Act
            var result = await _handler.HandleAsync(command, CancellationToken.None);

            //Assert
            result.IsSuccess
                .Should()
                .BeTrue();

            result
                .Should()
                .NotBeNull();

            _foodReposiroryMock.Verify(repo => repo.AddAsync(
                It.IsAny<FoodEntity>(),
                It.IsAny<CancellationToken>()),
                Times.Once);
        }
    }
}