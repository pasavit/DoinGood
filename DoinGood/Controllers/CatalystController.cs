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
        public ActionResult CatalystIndex()
        {
            var identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var catalyst = _repo.Catalyst.GetCatalyst(identityUserId);
            if (catalyst == null)
            {
                return RedirectToAction("CatalystCreate");
            }
            var catalystList = _repo.Catalyst.FindAll().ToList();
            return View(catalystList);
        }

        public ActionResult CatalystDetail(int id)
        {
            var catalyst = _repo.Catalyst.GetCatalystDetails(id);
            return View(catalyst);
        }

        public ActionResult CatalystCreate()
        {
            Catalyst catalyst = new Catalyst();
            return View(catalyst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CatalystCreate(Catalyst catalyst)
        {
            try
            {
                catalyst.IdentityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                catalyst = _repo.Catalyst.GeoCode(catalyst);
                _repo.Catalyst.Create(catalyst);
                _repo.Save();
                return RedirectToAction("CatalystIndex");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CatalystEdit(int id)
        {
            var catalyst = _repo.Catalyst.GetCatalystDetails(id);
            return View(catalyst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CatalystEdit(Catalyst catalyst)
        {
            try
            {
                _repo.Catalyst.Update(catalyst);
                _repo.Save();
                return RedirectToAction("CatalystIndex");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

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

        public ActionResult DeedDetail(int id)
        {
            var deed = _repo.Deed.GetDeedDetails(id);
            return View(deed);
        }
        
        public ActionResult DeedCreate()
        {
            Deed deed = new Deed();
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeedCreate(Deed deed)
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
        public ActionResult DeedEdit(int id)
        {
            var deed = _repo.Deed.GetDeedDetails(id);
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeedEdit(Deed deed)
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
        /////////////////////////////////////////////////////////////////
        /// Challenge
        /////////////////////////////////////////////////////////////////
        public ActionResult ChallengeCreate()
        {
            Deed deed = new Deed();
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChallengeCreate(Deed deed)
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
        /////////////////////////////////////////////////////////////////
        /// Donate
        /////////////////////////////////////////////////////////////////
        public ActionResult DonateIndex()
        {
            var donateList = _repo.Donate.FindAll().ToList();
            return View(donateList);
        }

        public ActionResult DonateDetail(int id)
        {
            var donate = _repo.Donate.GetDonateDetails(id);
            return View(donate);
        }

        public ActionResult DonateCreate()
        {
            Donate donate = new Donate();
            return View(donate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonateCreate(Donate donate)
        {
            try
            {
                _repo.Donate.Create(donate);
                _repo.Save();
                return RedirectToAction("DonateIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DonateEdit(int id)
        {
            var donate = _repo.Donate.GetDonateDetails(id);
            return View(donate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonateEdit(Donate donate)
        {
            try
            {
                _repo.Donate.Update(donate);
                _repo.Save();
                return RedirectToAction("DonateIndex");
            }
            catch
            {
                return View();
            }
        }
        /////////////////////////////////////////////////////////////////
        /// Task
        /////////////////////////////////////////////////////////////////
        public ActionResult TasksIndex()
        {
            var tasksList = _repo.Tasks.FindAll().ToList();
            return View(tasksList);
        }

        public ActionResult TaskDetail(int id)
        {
            var tasks = _repo.Tasks.GetTasksDetails(id);
            return View(tasks);
        }

        public ActionResult TasksCreate()
        {
            Tasks tasks = new Tasks();
            return View(tasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TasksCreate(Tasks tasks)
        {
            try
            {
                _repo.Tasks.Create(tasks);
                _repo.Save();
                return RedirectToAction("TasksIndex");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult TasksEdit(int id)
        {
            var tasks = _repo.Tasks.GetTasksDetails(id);
            return View(tasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TasksEdit(Tasks tasks)
        {
            try
            {
                _repo.Tasks.Update(tasks);
                _repo.Save();
                return RedirectToAction("TasksIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
