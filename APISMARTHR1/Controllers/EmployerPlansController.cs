using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISMARTHR1.Entities;

namespace APISMARTHR1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerPlansController : ControllerBase
    {
        private readonly EmployerContext _context;

        public EmployerPlansController(EmployerContext context)
        {
            _context = context;
        }

        // GET: api/EmployerPlans
        [HttpGet]
        public IEnumerable<EmployerPlan> GetEmployerPlan()
        {
            return _context.EmployerPlan;
        }

        // GET: api/EmployerPlans/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployerPlan([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employerPlan = await _context.EmployerPlan.FindAsync(id);

            if (employerPlan == null)
            {
                return NotFound();
            }

            return Ok(employerPlan);
        }

        // PUT: api/EmployerPlans/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployerPlan([FromRoute] int id, [FromBody] EmployerPlan employerPlan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employerPlan.EmployerPlanID)
            {
                return BadRequest();
            }

            _context.Entry(employerPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployerPlanExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployerPlans
        [HttpPost]
        public async Task<IActionResult> PostEmployerPlan([FromBody] EmployerPlan employerPlan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EmployerPlan.Add(employerPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployerPlan", new { id = employerPlan.EmployerPlanID }, employerPlan);
        }

        // DELETE: api/EmployerPlans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployerPlan([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employerPlan = await _context.EmployerPlan.FindAsync(id);
            if (employerPlan == null)
            {
                return NotFound();
            }

            _context.EmployerPlan.Remove(employerPlan);
            await _context.SaveChangesAsync();

            return Ok(employerPlan);
        }

        private bool EmployerPlanExists(int id)
        {
            return _context.EmployerPlan.Any(e => e.EmployerPlanID == id);
        }
    }
}