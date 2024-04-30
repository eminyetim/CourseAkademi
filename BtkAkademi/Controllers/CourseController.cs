using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]//Default(Standart) olarak HttpGet gelir. Burada veri göndereceğimiz anlamına gelir.
        [ValidateAntiForgeryToken] // Güvenlik amaçlı tarayıcıyı doğrular.
        public IActionResult Apply([FromForm] Candidate model) // Apply fonksiyonu overloading yaptık. 
        {
            //FromForm verinin formdan geliceğini bildiryoruz.
            //Model içindeki değişkenlerin doldurulması model binding.
            
            return View();
        }

    }
}