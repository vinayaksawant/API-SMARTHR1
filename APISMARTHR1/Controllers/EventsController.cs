using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISMARTHR1.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace APISMARTHR1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EmployerContext _context;

        public EventsController(EmployerContext context)
        {
            _context = context;
        }

        // GET: api/Events
        [HttpGet]
        public IEnumerable<Event> GetEvent()
        {
            return _context.Event;
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            /*Find() and FindAsync() are methods on type DbSet(which is what db.Items is).Include() 
             * returns a DbQuery object, which is why FindAsync() is not available. 
             * Use SingleOrDefaultAsync() to do the same thing as FindAsync()
             * (the difference is it will go straight to the database 
             * and won't look in the context to see if the entity exists first)...
             */
            //var @event = await _context.Event.FindAsync(id).Include(et => et.EventType);
            var @event = await _context.Event
                                        .Include(et => et.EventType)
                                        .FirstOrDefaultAsync(i=>i.EventID == id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent([FromRoute] int id, [FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.EventID)
            {
                return BadRequest();
            }


            if (_context.Event.Where(e => e.EmployerID == @event.EmployerID)
                                .Where(et => et.EventType.EventTypeID == @event.EventType.EventTypeID)
                                .Any()
                                )
            {
                ModelState.AddModelError("DuplicateEntry", $"Combination of Employer {@event.EmployerID} and EventTypeID {@event.EventType.EventTypeID} Already Present");
                return BadRequest(ModelState);
            }

            //_context.Entry(@event).State = EntityState.Modified;
            _context.Attach(@event);
            IEnumerable<EntityEntry> unchangedEntities = _context.ChangeTracker.Entries()
                                                        .Where(x => x.State == EntityState.Unchanged);
            foreach (EntityEntry ee in unchangedEntities)
            {
                ee.State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
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

        // POST: api/Events
        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Event.Where(e => e.EmployerID == @event.EmployerID)
                                .Where(et => et.EventType.EventTypeID == @event.EventType.EventTypeID)
                                .Any()
                                )
            {
                ModelState.AddModelError("DuplicateEntry", $"Combination of Employer {@event.EmployerID} and EventTypeID {@event.EventType.EventTypeID} Already Present");
                return BadRequest(ModelState);
            }


            @event.EventType = _context.EventType.Find(@event.EventType.EventTypeID);
            _context.Event.Add(@event);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return CreatedAtAction("GetEvent", new { id = @event.EventID }, @event);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();

            return Ok(@event);
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.EventID == id);
        }
    }
}