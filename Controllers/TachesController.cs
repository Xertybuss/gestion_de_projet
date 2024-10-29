using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectManager.Controllers
{
    public class TachesController : Controller
    {
        // GET: TachesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TachesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TachesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TachesController/Create
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

        // GET: TachesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TachesController/Edit/5
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

        // GET: TachesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TachesController/Delete/5
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
