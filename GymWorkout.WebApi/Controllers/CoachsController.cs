using GymWorkout.Application.Interfaces;
using GymWorkout.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymWorkout.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Coachs : ControllerBase
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public Coachs(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Coach>> GetCoachs()
        {
            return _applicationDbContext.Coachs.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Coach> GetCoach(string id)
        {
            var coach = _applicationDbContext.Coachs.Find(id);
            if (coach == null) { return NotFound("Not found"); }
            return coach;
        }

        [HttpPost]
        public ActionResult PostCoach(Coach coach) 
        {
            if (coach == null) { return NotFound("Not found"); }
            _applicationDbContext.Coachs.Add(coach);
            _applicationDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCoach), new { id = coach.Id }, coach);
        }
    }
}
