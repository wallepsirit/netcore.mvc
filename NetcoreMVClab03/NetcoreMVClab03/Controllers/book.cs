using Microsoft.AspNetCore.Mvc;

namespace NetcoreMVClab03.Controllers
{
    public class book : Controller
    { 
        protected book book = new book();
    {
        public IActionResult Index()
    {
            //danh sach cac selectitem  chuyen qua combobox:
            ViewBag.athors = book.authors;
            ViewBag.generes = book.generes;
            var books = book.getbooklist();
    }
        {
           
            return View(book);
        }
    }
}
