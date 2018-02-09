using Microsoft.AspNetCore.Mvc;
using service.Models;
using System.Collections.Generic;
using System.Linq;

namespace service.Controllers
{
    [Route("api/tr")]
    public class TransactionController : Controller
    {

        private readonly TodoContext _context;
        public TransactionController(TodoContext context)
        {
            _context = context;
            if (_context.TransactionItems.Count() == 0)
            {
                _context.Add(new TransactionItem { Amount = 0 });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<TransactionItem> GetAll()
        {
            return _context.TransactionItems.ToList();
        }
        [HttpGet("{id}",Name="GetTransaction")]

        public IActionResult GetById(int id){
            var item = _context.TransactionItems.FirstOrDefault(t => t.Id ==id);
            if (item == null){
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]

        public IActionResult Create([FromBody] TransactionItem item){
            if(item == null){
                return BadRequest();
            }
            _context.TransactionItems.Add(item);
            _context.SaveChanges();
            return Content("Added transaction successfully");
        }


    }
}