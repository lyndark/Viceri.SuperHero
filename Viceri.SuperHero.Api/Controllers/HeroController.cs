using Microsoft.AspNetCore.Mvc;
using Viceri.SuperHero.Api.Dto;
using Viceri.SuperHero.Api.Service;
using Viceri.SuperHero.Api.Exception;

namespace Viceri.SuperHero.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController(IHeroService heroService) : ControllerBase
    {
        public IHeroService HeroService { get; set; } = heroService;

        [HttpPost("CreateHero")]
        public async Task<ActionResult> CreateHero([FromBody] HeroRequestDto dto)
        {
            try
            {
                await HeroService.CreateHero(dto);

                return Ok(new ResponseDto
                {
                    Success = true,
                    Message = "Hero created successfully",
                    StatusCode = 201,
                });
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }

        [HttpPut("UpdateHero/{id}")]
        public async Task<ActionResult> UpdateHero(int id, [FromBody] HeroRequestDto dto)
        {
            try
            {
                await HeroService.UpdateHero(id, dto);

                return Ok(new ResponseDto
                {
                    Success = true,
                    Message = "Hero updated successfully",
                    StatusCode = 200,
                });
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }

        [HttpDelete("DeleteHero/{id}")]
        public async Task<ActionResult> DeleteHero(int id)
        {
            try
            {
                await HeroService.DeleteHero(id);

                return Ok(new ResponseDto
                {
                    Success = true,
                    Message = "Hero deleted successfully",
                    StatusCode = 200,
                });
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }

        [HttpGet("GetHero/{id}")]
        public async Task<ActionResult<HeroPowerResponseDto>> GetHero(int id)
        {
            try
            {
                var hero = await HeroService.GetHeroById(id);

                return Ok(hero);
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }

        [HttpGet("ListHero")]
        public async Task<ActionResult<IList<HeroResponseDto>>> ListHero()
        {
            try
            {
                var heroes = await HeroService.ListHero();

                return Ok(heroes);
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }

        [HttpGet("ListPower")]
        public async Task<ActionResult<IList<PowerResponseDto>>> ListPower()
        {
            try
            {
                var powers = await HeroService.ListPower();

                return Ok(powers);
            }
            catch (ApiException ex)
            {
                return ex.Response.StatusCode switch
                {
                    400 => BadRequest(ex.Response),
                    404 => NotFound(ex.Response),
                    500 => StatusCode(500, ex.Response),
                    _ => StatusCode(500, ex.Response),
                };
            }
        }
    }
}
