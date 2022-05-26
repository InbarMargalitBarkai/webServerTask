using Microsoft.AspNetCore.Mvc;

namespace webServerTask.Controllers
{
    public class apiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: api/invitations
        public IActionResult contacts()
        {
            return View();
        }

        // Post: api/invitations
        public async Task<IActionResult> contacts()
        {
            return View();
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
