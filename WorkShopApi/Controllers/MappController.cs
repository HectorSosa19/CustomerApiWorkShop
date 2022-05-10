using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkShopApi.Model;

namespace WorkShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MappController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MappController(IMapper mapper) {
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Add(CustomerRequest request)
        {
            CustomerModel Customer = _mapper.Map<CustomerModel>(request);
            return Ok(Customer);
        }
    }
}
