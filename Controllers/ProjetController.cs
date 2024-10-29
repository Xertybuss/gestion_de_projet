using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectManager.Controllers
{
    public class ProjetController : Controller
    {
        // GET: ProjetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProjetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjetController/Create
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

        // GET: ProjetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjetController/Edit/5
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

        // GET: ProjetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjetController/Delete/5
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
