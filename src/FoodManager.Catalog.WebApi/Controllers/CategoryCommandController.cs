using FoodManager.Catalog.Application.Input.Handlers.Commands;
using FoodManager.Internal.Shared.Http.Catalog.Requests;
using LiteBus.Commands.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FoodManager.Catalog.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryCommandController(ICommandMediator commandMediator) : ControllerBase
    {
        /// <summary>
        ///     Create new category
        /// </summary>
        /// <returns>The details of the newly created category item or a validation error.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var result = await commandMediator.SendAsync(new CreateCategoryCommand(request), cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Data);
        }
    }
}
