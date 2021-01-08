using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoinGood.Contracts;
using DoinGood.Data;
using DoinGood.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoinGood.Controllers
{
    public class FundController : Controller
    {
        private IRepositoryWrapper _repo;
        public FundController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
