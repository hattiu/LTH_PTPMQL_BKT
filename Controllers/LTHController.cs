using Microsoft.AspNetCore.Mvc;

namespace LTH_PTPMQL_BKT.Controllers
{
    public class LTHController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string HoTen, string NgaySinh, string GioiTinh, string DiaChi)
        {
            string strOuput = "Xin Chao" + HoTen + "/" + NgaySinh + "/" + GioiTinh + "/" + DiaChi;
            ViewBag.Message = strOuput;
            return View();
        }
    }
}