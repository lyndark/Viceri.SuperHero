using Microsoft.AspNetCore.Mvc;
using Viceri.SuperHero.Api.Dto;
using Viceri.SuperHero.Api.Service;

namespace Viceri.SuperHero.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        public IHeroService HeroService { get; set; }

        public HeroController(IHeroService heroService) 
        {
            HeroService = heroService;
        }

        [HttpPost("CreateHero")]
        public async Task<ActionResult> CreateHero([FromBody] CreateHeroRequestDto dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest("Invalid request");
                }
                await HeroService.CreateHero(dto);
                var response = new ResponseDto()
                {
                    Success = true,
                    Message = "Hero created successfully",
                    StatusCode = 201,
                };

                return Ok("Hero created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }
    }
}
