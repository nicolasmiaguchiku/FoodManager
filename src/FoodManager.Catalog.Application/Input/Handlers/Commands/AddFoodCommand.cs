using FoodManager.Catalog.Application.Input.Requests;
using FoodManager.Catalog.Application.Output.Response;
using LiteBus.Commands.Abstractions;
using Mattioli.Configurations.Models;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public record AddFoodCommand(AddFoodRequest FoodRequest) : ICommand<Result<GetFoodResponse>>;