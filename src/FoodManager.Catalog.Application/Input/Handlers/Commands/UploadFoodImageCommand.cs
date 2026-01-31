using FoodManager.Catalog.Application.Input.Requests;
using LiteBus.Commands.Abstractions;
using Mattioli.Configurations.Models;

namespace FoodManager.Catalog.Application.Input.Handlers.Commands;

public sealed record UploadFoodImageCommand(Guid Id, UploadFoodImageRequest Request) : ICommand<Result>;