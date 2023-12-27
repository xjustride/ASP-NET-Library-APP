using Data;
using Labolatorium_3_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Labolatorium_3_App.Controllers
{
    [Route("api/libraries")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LibrariesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("filter")]
        public IActionResult GetFilteredLibraries(string query)
        {
            var result = _context.Libraries
                .Where(o => o.Name.ToUpper().StartsWith(query.ToUpper()))
                .Select(o => new
                {
                    Id = o.Id,
                    Name = o.Name
                }).ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetLibraryById(int id)
        {
            var entity = _context.Libraries
                .Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(entity);
            }
        }
    }
}
