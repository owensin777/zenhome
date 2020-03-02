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
        private readonly IVillageConsumptionRepository mVillageRepository;
        private readonly IElectricCounterRepository mElectricCounterRepository;
        public HomeController(IVillageConsumptionRepository villageRepository, IElectricCounterRepository ElectricCounterRepository)
        {
            mElectricCounterRepository = ElectricCounterRepository;
            mVillageRepository = villageRepository;
        }
        [HttpGet("getConsumptionReport")]
        public IActionResult PrintConsumptionReport([FromQuery] int Duration)
        {
            return Ok(mVillageRepository.GetAllVillage(Duration));
        }

        public IActionResult PostElecticityConsumption([FromQuery]double ConsumptionAmount)
        {
            //Call external api to get village id
            Int32.TryParse(Request.Headers["countid"], out int CounterId);
            var Village = mElectricCounterRepository.GetVillageByCounterId(CounterId);
            mVillageRepository.BookingVillageConsumption(Village.Id, ConsumptionAmount);
            //Post consumption entries to DB with current time and amount
            return Ok();
        }
    }
}
