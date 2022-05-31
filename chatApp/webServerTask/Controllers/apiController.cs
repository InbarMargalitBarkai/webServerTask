using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webServerTask.Models;

namespace webServerTask.Controllers
{
    public class apiController : Controller
    {
        private readonly webServerTaskContext _context;
        public apiController(webServerTaskContext context)
        {
            _context = context;
        }

    public IActionResult Index()
        {
            return View();
        }

        // GET: api/contacts
        // return the contacts user
        public IActionResult contacts()
        {
            return View();
        }

        // Post: api/contacts
        public async Task<IActionResult> contacts(User? user)
        {
            var u = await _context.User.FirstOrDefaultAsync(e => e.Id == user.Id);
            if (u == null)
            {
                return NotFound();
            }
            return View(u.Contacts);
        }

        // POST: api/invitations
        public IActionResult invitations()
        {
            return View();
        }

        // POST: api/transfer
        public IActionResult transfer()
        {
            return View();
        }
    }
}

