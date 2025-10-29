using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Context;
using ProductsAPI.Models;
using ProductsAPI.Services;
using System;
using System.Threading.Tasks;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalApiController : ControllerBase
    {
        private readonly ProductDbContext _context;
        private readonly ExternalApiService _externalApiService;

        public ExternalApiController(ProductDbContext context, ExternalApiService externalApiService)
        {
            _context = context;
            _externalApiService = externalApiService;
        }

        [HttpGet("currency/{from}")]
        public async Task<IActionResult> GetCurrencyRate(string from)
        {
            try
            {
                var result = await _externalApiService.GetCurrencyDataAsync(from);
                var log = new ExternalApiLog
                {
                    ApiName = "CurrencyRateAPI",
                    RequestUrl = $"https://api.exchangerate-api.com/v4/latest/{from}",
                    ResponseData = result,
                    CalledAt = DateTime.Now
                };

                _context.ExternalApiLogs.Add(log);
                await _context.SaveChangesAsync();
                return Ok(new
                {
                    Message = "Data fetched successfully.",
                    From = from,
                    ApiResponse = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error", Error = ex.Message });
            }
        }
    }
}
