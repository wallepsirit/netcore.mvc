using lesson04.lab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson04.lab.Controllers
{
    public class peoplecontroller : Controller
    {
        

        // GET: peoplecontroller
        public ActionResult Index()
        {
            var _peoples = datalocal.getpeoples();


            return View(_peoples);
        }

        // GET: peoplecontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: peoplecontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: peoplecontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: peoplecontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: peoplecontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: peoplecontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: peoplecontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
