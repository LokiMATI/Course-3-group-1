using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace WebApplicationAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public Controller(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                return Ok(await response.Content.ReadAsStringAsync());
            }
            catch (Exception)
            {
                return BadRequest(url);
            }
        }
    }
}
