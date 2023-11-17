using GymWorkout.Application.Interfaces;
using GymWorkout.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymWorkout.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public TestController(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public ActionResult Test()
        {
            _applicationDbContext.Coaches.ToList();
            _applicationDbContext.Participants.ToList();
            _applicationDbContext.Exercises.ToList();
            _applicationDbContext.TrainingDays.ToList();
            _applicationDbContext.ExerciseVariables.ToList();

            return Ok();
        }

        //[HttpGet("{id}")]
        //public ActionResult<Coach> GetCoach(string id)
        //{
        //    var coach = _applicationDbContext.Coaches.Find(id);
        //    if (coach == null) { return NotFound("Not found"); }
        //    return coach;
        //}

        //[HttpPost]
        //public ActionResult PostCoach(Coach coach) 
        //{
        //    if (coach == null) { return NotFound("Not found"); }
        //    _applicationDbContext.Coaches.Add(coach);
        //    _applicationDbContext.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetCoach), new { id = coach.Id }, coach);
        //}
    }
}
