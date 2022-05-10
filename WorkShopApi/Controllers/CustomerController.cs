using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkShopApi.Context;
using WorkShopApi.Model;

namespace WorkShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private static List<CustomerModel> customers = new List<CustomerModel>
        {
                new CustomerModel {
                    idCostumer = 1,
                    FirstName = "Hector",
                    LastName = "Jose",
                    Age = 19,
                    Phone = "809-224-2451",
                    Email ="Hectorsosa@gmail.com",
                    City = "Santo Domingo",
                    ZipCode = 10014,
                    DateOfBirth= DateTime.Now,
                    Stature = 6,
                    IsHuman = true,
                },
                new CustomerModel {
                    idCostumer = 2,
                    FirstName = "Martin",
                    LastName = "El capo",
                    Age = 30,
                    Phone = "809-123-4532",
                    Email ="MartinElCapo@gmail.com",
                    City = "Santo Domingo",
                    ZipCode = 10014,
                    DateOfBirth= DateTime.Now,
                    Stature = 5,
                    IsHuman = true,
                }

        };
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<CustomerModel>>> Get()
        {
            return Ok(await _context.customerModels.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CustomerModel>>> Get(int idCostumer)
        {
            var customer = await _context.customerModels.FindAsync(idCostumer);
            if (customer == null)
                return BadRequest("Product Not Found");
            return Ok(customers);
        }
        [HttpPost]
        public async Task<ActionResult<List<CustomerModel>>> AddCostumer(CustomerModel customer)
        {
            _context.customerModels.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(await _context.customerModels.ToListAsync());
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<CustomerModel>>> UpdateCostumer(CustomerModel request)
        {
            var dbproduct = await _context.customerModels.FindAsync(request.idCostumer);
            if (dbproduct == null)
            return BadRequest("Product Not Found");
            dbproduct.FirstName = request.FirstName;
            dbproduct.LastName = request.LastName;
            dbproduct.Age = request.Age;
            dbproduct.Phone = request.Phone;
            dbproduct.Email = request.Email;
            dbproduct.City = request.City;
            dbproduct.ZipCode = request.ZipCode;
            dbproduct.DateOfBirth = request.DateOfBirth;
            dbproduct.Stature = request.Stature;
            dbproduct.IsHuman = request.IsHuman;
            await _context.SaveChangesAsync();
            return Ok(await _context.customerModels.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CustomerModel>>> DeleteCostumer(int idCostumer)
        {
            var dbcustomer = await _context.customerModels.FindAsync(idCostumer);
            if (dbcustomer == null)
                return BadRequest("Product Not Found");
            _context.customerModels.Remove(dbcustomer);
            await _context.SaveChangesAsync();
            return Ok(await _context.customerModels.ToListAsync());
        }
    }
}
