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
        private readonly IVillageConsumptionRepository mVillageConsumptionRepository;
        private readonly IElectricCounterRepository mElectricCounterRepository;
        public HomeController(IVillageConsumptionRepository villageConsumptionRepository, IElectricCounterRepository ElectricCounterRepository)
        {
            mElectricCounterRepository = ElectricCounterRepository;
            mVillageConsumptionRepository = villageConsumptionRepository;
        }
        [HttpGet("getConsumptionReport")]
        public IActionResult PrintConsumptionReport([FromQuery] int Duration)
        {
            return Ok(mVillageConsumptionRepository.GetAllVillage(Duration));
        }
        [HttpPost("bookelectricityconsumption")]
        public IActionResult PostElecticityConsumption([FromQuery]double ConsumptionAmount)
        {
            //Call external api to get village id
            Int32.TryParse(Request.Headers["counterid"], out int CounterId);
            var Village = mElectricCounterRepository.GetVillageByCounterIdAsync(CounterId).Result;
            mVillageConsumptionRepository.BookingVillageConsumption(Village.Id, ConsumptionAmount);
            //Post consumption entries to DB with current time and amount
            return Ok();
        }
    }
}
