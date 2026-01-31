using Microsoft.AspNetCore.Http;

namespace FoodManager.Catalog.Application.Input.Requests
{
    public record ImportImageFoodFileRequest
    {
        public required IFormFile File { get; set; }
        public required string FileImage { get; set; }
    }
}