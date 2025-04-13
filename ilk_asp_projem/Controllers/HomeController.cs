using ilk_asp_projem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilk_asp_projem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            var book = new List<kitap>()
            {
                new kitap() {ID=1,bookName="Araba Sevdası",bookWriter="Recaizade Mahmut Ekrem" },
                new kitap() {ID=2,bookName="Yaprak Dökümü",bookWriter="Reşat Nuri Gültekin" },
                new kitap() {ID=3,bookName="Aşk-ı Memnu",bookWriter="Halit Ziya Uşaklıgil" }
            };
            return View(book);
        }
    }
}
