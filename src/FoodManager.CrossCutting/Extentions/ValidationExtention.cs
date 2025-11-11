using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using FoodManager.Application.Input.Handlers.Commands;
using FoodManager.Application.Validations;

namespace FoodManager.CrossCutting.Extentions
{
    public static class ValidationExtention
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(options =>
            {
                options.DisableDataAnnotationsValidation = true;
            });
            
            services.AddScoped<IValidator<AddFoodCommand>, AddFoodValidator>();
            return services;
        }
    }
}