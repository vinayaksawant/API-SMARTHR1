using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISMARTHR1.Entities;
using APISMARTHR1.DTO;
using AutoMapper;

namespace APISMARTHR1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployerContext _context;

        public EmployeesController(EmployerContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employee_Entity1 = from x in _context.EmployeeEvent
                                   .Include(a => a.EmployeeAddress)
                                    .Include("EmployeeAddress.AddressType")
                                   .Include(e => e.EmployeeEmail)
                                    .Include("EmployeeEmail.EmailType")
                                   .Include(p => p.EmployeePhone)
                                    .Include("EmployeePhone.PhoneType")
                                   group x by x.Employee.EmployeeID into g
                                   orderby g.Key
                                   select g.OrderByDescending(z => z.EmployeeEventID).FirstOrDefault();


            IList<Employee_DTO> employee_DTO = new List<Employee_DTO>();

            foreach (EmployeeEvent e in employee_Entity1)
            {
                var employee_DTO_single = Mapper.Map<Employee_DTO>(e);
                employee_DTO.Add(employee_DTO_single);
            };

            if (employee_DTO == null)
            {
                return NotFound();
            }

            return Ok(employee_DTO);
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = await _context.Employee.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // GET: api/Employees/5/Dependents
        [HttpGet("{id}/Dependents")]
        public async Task<IActionResult> GetEmployeeWithDependents([FromRoute] int id)
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
            //var employee = await _context.Employee.FindAsync(id);

            var employee = await _context.Employee
                                        .Include(dp => dp.Dependent)
                                        .FirstOrDefaultAsync(e => e.EmployeeID == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // GET: api/Employees/5/Dependents
        [HttpGet("{id}/Beneficiaries")]
        public async Task<IActionResult> GetEmployeeWithBeneficiaries([FromRoute] int id)
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
            //var employee = await _context.Employee.FindAsync(id);

            var employee = await _context.Employee
                                        .Include(bn => bn.Beneficiary)
                                        .FirstOrDefaultAsync(e => e.EmployeeID == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] Employee employee)
        {
            #region Old Code
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != employee.EmployeeID)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(employee).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!EmployeeExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            #endregion Old Code
            return NoContent();

        }

        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.EmployeeID }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();

            return Ok(employee);
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeID == id);
        }
    }
}