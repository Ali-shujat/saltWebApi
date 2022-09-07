using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private Db _db;
        public AddressBookController(Db db)
        {
            _db = db;
        }


        // GET: api/<AddressBookController>
        [HttpGet]
        public List<AddressBook> Get()
        {
            return _db.Addresses;
        }

        // GET api/<AddressBookController>/5
        [HttpGet("{id}")]
        public AddressBook? Get(int id)
        {
            return _db.Addresses.Find(d => d.Id == id);
        }

        // POST api/<AddressBookController>
        [HttpPost]
        public IActionResult CreateNewAddress(AddressBook request)
        {
            var nextId = _db.Addresses.Count + 1;
            var newAddress = new AddressBook()
            {
                Id = nextId,
                Name = request.Name,
                PostCode = request.PostCode,
                Address= request.Address,
                City = request.City,
            };
            _db.Addresses.Add(newAddress);
            return CreatedAtAction(nameof(Get), new { id = nextId }, newAddress);

        }

        // PUT api/<AddressBookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AddressBookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
