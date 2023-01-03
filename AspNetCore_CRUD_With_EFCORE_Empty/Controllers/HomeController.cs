using Microsoft.AspNetCore.Mvc;
using AspNetCore_CRUD_With_EFCORE_Empty.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_CRUD_With_EFCORE_Empty.Controllers
{
    public class HomeController : Controller
    {
        iakademi45Context context = new iakademi45Context();
        public async Task<IActionResult> Index()
        {
            return View(await context.Students.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentName,Department,Age,StudentNumber")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
