using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApelloWebAppMVC.Controllers
{
    public class temp : Controller
    {
        // GET: temp
        public ActionResult Index()
        {
            return View();
        }

        // GET: temp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: temp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: temp/Create
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

        // GET: temp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: temp/Edit/5
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

        // GET: temp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: temp/Delete/5
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
