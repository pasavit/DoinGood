using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DoinGood.Contracts;
using DoinGood.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoinGood.Controllers
{
    public class CatalystController : Controller
    {
        private IRepositoryWrapper _repo;

        public CatalystController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        // GET: CatalystController
        public ActionResult Index()
        {
            var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var catalyst = _repo.Catalyst.GetCatalyst(identityUserId);
            if (catalyst == null)
            {
                return RedirectToAction("Create");
            }
            return View();
        }

        // GET: CatalystController/Details/5
        public ActionResult Details(int id)
        {
            var catalyst = _repo.Catalyst.GetCatalystDetails(id);
            return View();
        }

        // GET: CatalystController/Create
        public ActionResult Create()
        {
            Catalyst catalyst = new Catalyst();
            return View(catalyst);
        }

        // POST: CatalystController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Catalyst catalyst)
        {
            try
            {
                //catalyst.IdentityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _repo.Catalyst.Create(catalyst);
                _repo.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalystController/Edit/5
        public ActionResult Edit(int id)
        {
            var catalyst = _repo.Catalyst.GetCatalystDetails(id);
            return View(catalyst);
        }

        // POST: CatalystController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Catalyst catalyst)
        {
            try
            {
                _repo.Catalyst.Update(catalyst);
                _repo.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalystController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatalystController/Delete/5
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
        /////////////////////////////////////////////////////////////////
        /// Deed
        /////////////////////////////////////////////////////////////////
        public ActionResult DeedIndex()
        {
            var deedList = _repo.Deed.FindAll().ToList();
            return View(deedList);
        }

        public ActionResult ViewDeed(int id)
        {
            var deed = _repo.Deed.GetDeedDetails(id);
            return View(deed);
        }
        
        public ActionResult CreateDeed()
        {
            Deed deed = new Deed();
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDeed(Deed deed)
        {
            try
            {
                _repo.Deed.Create(deed);
                _repo.Save();
                return RedirectToAction("DeedIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditDeed(int id)
        {
            var deed = _repo.Deed.GetDeedDetails(id);
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDeed(Deed deed)
        {
            try
            {
                _repo.Deed.Update(deed);
                _repo.Save();
                return RedirectToAction("DeedIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
