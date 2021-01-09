using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DoinGood.Contracts;
using DoinGood.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var catalyst = _repo.Catalyst.GetCatalyst(User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            catalyst.IdentityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            catalyst = _repo.Catalyst.GeoCode(catalyst);
            _repo.Catalyst.Create(catalyst);
            _repo.Save();
            return RedirectToAction("CatalystIndex");
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
            catalyst = _repo.Catalyst.GeoCode(catalyst);
            _repo.Catalyst.Update(catalyst);
            _repo.Save();
            return RedirectToAction("CatalystIndex");
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
            var deedList = _repo.Deed.DeedList();
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
            ViewBag.fundList = _repo.Fund.FundList();
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeedCreate(Deed deed)
        {
            deed.CatalystId = _repo.Catalyst.GetCatalyst(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).CatalystId;
            _repo.Deed.Create(deed);
            _repo.Save();
            return RedirectToAction("DeedIndex");
        }
        public ActionResult DeedEdit(int id)
        {
            ViewBag.fundList = _repo.Fund.FundList();
            var deed = _repo.Deed.GetDeedDetails(id);
            return View(deed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeedEdit(Deed deed)
        {
            _repo.Deed.Update(deed);
            _repo.Save();
            return RedirectToAction("DeedIndex");
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
            _repo.Deed.Create(deed);
            _repo.Save();
            return RedirectToAction("DeedIndex");
        }
        /////////////////////////////////////////////////////////////////
        /// Donate
        /////////////////////////////////////////////////////////////////
        public ActionResult DonateIndex()
        {
            var donateList = _repo.Donate.DonateList();
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
            ViewBag.fundList = _repo.Fund.FundList();
            return View(donate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonateCreate(Donate donate)
        {
            donate.PosterCatalystId = _repo.Catalyst.GetCatalyst(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).CatalystId;
            _repo.Donate.Create(donate);
            _repo.Save();
            return RedirectToAction("DonateIndex");
        }
        public ActionResult DonateEdit(int id)
        {
            ViewBag.fundList = _repo.Fund.FundList();
            var donate = _repo.Donate.GetDonateDetails(id);
            return View(donate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonateEdit(Donate donate)
        {
            _repo.Donate.Update(donate);
            _repo.Save();
            return RedirectToAction("DonateIndex");
        }
        /////////////////////////////////////////////////////////////////
        /// Task
        /////////////////////////////////////////////////////////////////
        public ActionResult TasksIndex()
        {
            var tasksList = _repo.Tasks.TasksList();
            return View(tasksList);
        }

        public ActionResult TasksDetail(int id)
        {
            var tasks = _repo.Tasks.GetTasksDetails(id);
            return View(tasks);
        }

        public ActionResult TasksCreate()
        {
            Tasks tasks = new Tasks();
            ViewBag.fundList = _repo.Fund.FundList();
            return View(tasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TasksCreate(Tasks tasks)
        {
            tasks.PosterCatalystId = _repo.Catalyst.GetCatalyst(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).CatalystId;
            _repo.Tasks.Create(tasks);
            _repo.Save();
            return RedirectToAction("TasksIndex");
        }
        public ActionResult TasksEdit(int id)
        {
            ViewBag.fundList = _repo.Fund.FundList();
            var tasks = _repo.Tasks.GetTasksDetails(id);
            return View(tasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TasksEdit(Tasks tasks)
        {
            _repo.Tasks.Update(tasks);
            _repo.Save();
            return RedirectToAction("TasksIndex");
        }
        public ActionResult TasksAccept(int id)
        {
            var tasks = _repo.Tasks.GetTasksDetails(id);
            tasks.TaskerCatalystId = _repo.Catalyst.GetCatalyst(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).CatalystId;
            _repo.Tasks.Update(tasks);
            _repo.Save();
            return View(tasks);
        }
        public ActionResult TasksCompleted(int id)
        {
            ViewBag.fundList = _repo.Fund.FundList();
            var tasks = _repo.Tasks.GetTasksDetails(id);
            return View(tasks);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TasksCompleted(Tasks tasks, int posterValue, int taskerValue)
        {
            var user = _repo.Catalyst.GetCatalyst(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).CatalystId;
            if (user == tasks.PosterCatalystId)
            {
                _repo.Tasks.PosterComplete(tasks, posterValue, taskerValue);
            }
            else
            {
                _repo.Tasks.TaskerComplete(tasks, posterValue, taskerValue);
            }
            _repo.Tasks.Update(tasks);
            _repo.Catalyst.Update(tasks.PosterCatalyst);
            _repo.Fund.Update(tasks.Fund);
            _repo.Fund.Update(tasks.TaskerFund);
            _repo.Save();
            return RedirectToAction("TasksIndex");
        }
    }
}
