using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfraMgmt.Data;

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
            return View();
        }
        [HttpGet]
        [Route("api/assets/all")]
        public IActionResult GetAllAssets()
        {
            return Ok(_ctx.Assets.Select(a => a));
        }
    }
}