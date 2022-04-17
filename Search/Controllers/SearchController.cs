using Microsoft.AspNetCore.Mvc;
using Search.Contracts;
using Search.Models;

namespace Search.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            this._searchService = searchService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SearchModel search)
        {
            var result = await _searchService.Search(search);
            return Ok(result);
        }
    }
}