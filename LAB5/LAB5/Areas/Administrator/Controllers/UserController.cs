using System.Collections.Generic;
using LAB5.Areas.Administrator.Models;
using Microsoft.AspNetCore.Mvc;
namespace LAB5.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UserController : Controller
    {
        public static List<User> _users = new List<User>()
        {
                new User() { id = 1, name = "Herman Beck", progress = 25,
                amount = 77.99, deadline = DateTime.Now, image = "face1.jpg" },
                new User() { id = 2, name = "Messsy Adam", progress = 75,
                amount = 222.99, deadline = DateTime.Now, image = "face2.jpg" },
                new User() { id = 3, name = "John Richards", progress = 80,
                amount = 123.99, deadline = DateTime.Now, image = "face3.jpg" },
                new User() { id = 4, name = "Peter Meggik", progress = 95,
                amount = 432.99, deadline = DateTime.Now, image = "face4.jpg" },
                new User() { id = 5, name = "Edward", progress = 100,
                amount = 111.99, deadline = DateTime.Now, image = "face5.jpg" },
                new User() { id = 6, name = "John Doe", progress = 30,
                amount = 22.22, deadline = DateTime.Now, image = "face6.jpg" },
                new User() { id = 7, name = "Henry Tom", progress = 45,
                amount = 47.99, deadline = DateTime.Now, image = "face7.jpg" },
            };
        public IActionResult Index()
        {
            return View(_users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _users.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Index"); // hoặc return BadRequest();

            var user = _users.FirstOrDefault(u => u.id == id.Value);
            if (user == null) return NotFound();

            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var existingUser = _users.FirstOrDefault(u => u.id == updatedUser.id);
            if (existingUser == null) return NotFound();

            existingUser.name = updatedUser.name;
            existingUser.progress = updatedUser.progress;
            existingUser.amount = updatedUser.amount;
            existingUser.deadline = updatedUser.deadline;
            existingUser.image = updatedUser.image;

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.id == id);
            if (user != null) _users.Remove(user);
            return RedirectToAction("Index");
        }



    }
}
