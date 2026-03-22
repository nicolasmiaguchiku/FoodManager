using FoodManager.Catalog.Application.Output.Queries;
using FoodManager.Internal.Shared.Attributes;
using FoodManager.Internal.Shared.Http.Catalog.Requests;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodManager.Catalog.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/food")]
    [Authorize]
    public class FoodQueriesControllers(IQueryMediator queryMediator) : ControllerBase
    {

        /// <summary>
        //      Get a list of foods filtered according to the criteria provided.
        /// </summary>
        /// <returns> A collection of food items that contains filters or a validation error.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [RequiredRole("ViewFood")]
        public async Task<IActionResult> GetAllFoodsAsync([FromQuery] GetFoodRequest query, CancellationToken cancellationToken)
        {
            var result = await queryMediator.QueryAsync(new GetFoodQuery(query), cancellationToken);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Error);
        }
    }
}