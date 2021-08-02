using BroccoliSoup.Logic.Recipes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BroccoliSoup.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesReader _recipesReader;

        public RecipesController(IRecipesReader recipesReader)
        {
            _recipesReader = recipesReader;
        }

        [HttpGet("")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<RecipeName>))]
        [SwaggerResponse(500)]
        public ActionResult<IEnumerable<RecipeName>> GetRecipes() => _recipesReader.GetAllRecipes();
        [HttpGet("Steps/{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<RecipeStep>))]
        [SwaggerResponse(500)]
        public ActionResult<IEnumerable<RecipeStep>> GetSteps(int id) => _recipesReader.GetSteps(id);

    }
}
