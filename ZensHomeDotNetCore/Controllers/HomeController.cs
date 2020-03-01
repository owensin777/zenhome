using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZensHomeDotNetCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZensHomeDotNetCore.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IVillageRepository mVillageRepository;

        public HomeController(IVillageRepository villageRepository)
        {
            mVillageRepository = villageRepository;
        }
        [HttpGet("getConsumptionReport")]
        public IActionResult PrintConsumptionReport()
        {
            mVillageRepository.BookingVillageConsumption(0, 0);
            mVillageRepository.GetAllVillage();
            return Ok(mVillageRepository.GetAllVillage());
        }

        public IActionResult PostElecticityConsumption()
        {
            //Call external api to get village id

            //Post consumption entries to DB with current time and amount
            return Ok();
        }
    }
}
