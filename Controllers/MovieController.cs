using Microsoft.AspNetCore.Mvc;
using FetchWebapi.Data;
using FetchWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace FetchWebapi.Controllers{
[ApiController]
  public class FetchMovieController : ControllerBase{
      private readonly Appdbcontext context;
        public FetchMovieController(Appdbcontext context){
            this.context=context; 
        }
 

         [Route("api/FetchMovie")]
         [HttpGet]
        public async Task<IEnumerable<MovieDetails>>Get(){
            return await context.MovieDetails.ToListAsync();
        }


        [Route("api/FetchMovie/{id}")]
        [HttpGet]
        public ActionResult<MovieDetails> GetIndividual(int id)
        {
           var movie = context.MovieDetails.Find(id);
           if (movie == null)
           {
             return NotFound();
           }
           return Ok(movie);
         }

        [Route("api/TotalMovie")]
        [HttpGet]
         public ActionResult<MovieDetails> TotalCount()
        {
            var MovieCount=  context.MovieDetails.ToList().Count;
            
            return Ok(MovieCount);
         }

        }
}
    
