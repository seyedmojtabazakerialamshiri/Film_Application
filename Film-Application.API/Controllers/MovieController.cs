using Film_Application.Core.Services;
using Microsoft.AspNetCore.Mvc;


namespace Film_Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IFilmService _iFilmService;

        /// <summary>
        /// Constructor of controller
        /// </summary>
        /// <param name="iFilmService"></param>
        public MovieController(IFilmService iFilmService)
        {
            _iFilmService = iFilmService;
        }

        /// <summary>
        /// Get all pictures from data source
        /// </summary>
        /// <returns>Return Pictures</returns>
        [HttpGet]
        [Route("GetPictures")]
        public IActionResult GetPictures()
        {
            var pictures = _iFilmService.GetAllFilms();
            return Ok(pictures);
        }



    }
}