using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webServerTask.Data;
using webServerTask.Models;

namespace webServerTask.Controllers
{
    public class UsersController : Controller
    {
        private readonly webServerTaskContext _context;

        public UsersController(webServerTaskContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
              return _context.User != null ? 
                          View(await _context.User.ToListAsync()) :
                          Problem("Entity set 'webServerTaskContext.User'  is null.");
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            User model = new User();
            return View(model);
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<object> Create([Bind("Id,Username,Nickname,Password,ConfirmPassword")] User user)
        {
            // check if user already exist in database
            if (_context.User.Any(m => m.Username == user.Username))
            {
                await Response.WriteAsync("<script>alert('User already exist. Please press enter on the url to re rgister');</script>");
                // I dont know how to do it will come here after the alert, so I asked the user to press enter on the url
                return View();
            }
            else if (user.Username.Length == 0)
            {
                return View();
            }
            else if (user.Nickname.Length == 0)
            {
                return View();
            }
            else if (user.Password.Length == 0)
            {
                return View();
            }
            else if (user.ConfirmPassword.Length == 0)
            {
                return View();
            }
            else if (user.Password.Length < 8)
            {
                return View();

            }
            else if (Regex.Matches(user.Password, @"[a-zA-Z]").Count < 1)
            {
                return View();
            }
            else if (Regex.Matches(user.Password, @"[0-9]").Count < 1)
            {
                return View();
            }
            else if (!(user.Password.Equals(user.ConfirmPassword)))
            {
                return View();
            }
            else if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ChatAfterRegister));
                //return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Users/Login

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<object> Login([Bind("Id,Username,Nickname,Password,ConfirmPassword")] User user)
        {
            if (!(_context.User.Any(m => m.Username == user.Username)))
            {
                await Response.WriteAsync("<script>alert('User doesnt exist. Please press enter on the url to re login');</script>");
                // I dont know how to do it will come again after the alert, so I ask the user to do enter in the url
            }
            else
            {
                if (!(_context.User.Any(m => m.Password == user.Password)))
                {
                    await Response.WriteAsync("<script>alert('Password isnt correct. Please press enter on the url to re login');</script>");
                }
                // If the login is valid
                else
                {
                    return RedirectToAction(nameof(ChatAfterLogin));

                }
            }
            return View();
        }

        // GET: Users/ChatAfterRegister
        public IActionResult ChatAfterRegister()
        {
            return View();
        }

        // GET: Users/ChatAfterLogin
        public IActionResult ChatAfterLogin()
        {
            return View();
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Nickname,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.User == null)
            {
                return Problem("Entity set 'webServerTaskContext.User'  is null.");
            }
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
          return (_context.User?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
