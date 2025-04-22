using LAB2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            // Logic thêm task
            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, Todo todo)
        {
            // Logic sửa task
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
