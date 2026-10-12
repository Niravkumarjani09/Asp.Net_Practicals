using prectical_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prectical_7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> _feedbackList = new List<Feedback>();
        [HttpGet]
        public ActionResult Index()
        {

            return View(_feedbackList);

        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback model)
        {

            if (ModelState.IsValid)
            {

                _feedbackList.Add(model);
                TempData["SuccessMessage"] = "Feedback submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
