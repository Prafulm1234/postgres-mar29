using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using postgresmar29.Models;

namespace postgresmar29.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly postgresmar29dbContext _context;

        public FilmController(postgresmar29dbContext context)
        {
            _context = context;
        }
		

   [HttpGet]

   public async Task<ActionResult<List<Film>>> GetFilm()
   {
		return Ok(await _context.Film.ToListAsync());
   }
		
		



		





		

	[HttpPost]

	public async Task<ActionResult<Store>> CreateFilm(Film mdlPostPyload)
	{
		_context.Film.Add(mdlPostPyload);
		await _context.SaveChangesAsync();
		return CreatedAtAction("GetFilm", new { id = mdlPostPyload.FilmId }, mdlPostPyload);
	}
		



		


    }
}
