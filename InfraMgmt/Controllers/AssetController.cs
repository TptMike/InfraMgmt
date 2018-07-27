using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfraMgmt.Data;
using InfraMgmt.Models;
using InfraMgmt.Models.ViewModels;

namespace InfraMgmt.Controllers
{
    public class AssetController : Controller
    {
        private InfraDbContext _ctx;
        public AssetController(InfraDbContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            AssetModel am = new AssetModel(_ctx);
            AssetIndexViewModel vm = new AssetIndexViewModel();
            vm.Assets = am.GetAll();
            return View(vm);
        }
        [HttpGet]
        [Route("api/assets/all")]
        public IActionResult GetAllAssets()
        {
            return Ok(_ctx.Assets.Select(a => a));
        }
    }
}