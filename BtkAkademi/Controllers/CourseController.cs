using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]//Default(Standart) olarak HttpGet gelir. Burada veri göndereceğimiz anlamına gelir.
        [ValidateAntiForgeryToken] // Güvenlik amaçlı tarayıcıyı doğrular.
        public IActionResult Apply([FromForm] Candidate model) // Apply fonksiyonu overloading yaptık. 
        {
            if(Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is already an application for you.");
            }
            //FromForm verinin formdan geliceğini bildiryoruz.
            //Model içindeki değişkenlerin doldurulması model binding.
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("FeedBack", model);
            }
            else
                return View();
        }
    }
}