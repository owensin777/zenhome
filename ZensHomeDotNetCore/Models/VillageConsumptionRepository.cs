using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;
using Microsoft.EntityFrameworkCore;

namespace ZensHomeDotNetCore.Models
{
    public class VillageConsumptionRepository : RepositoryBase<VillageConsumption, MyDbContext>, IVillageConsumptionRepository
    {
        public VillageConsumptionRepository(String DbConnectionString) : base(new MyDbContext(DbConnectionString))
        {

        }

        public void BookingVillageConsumption(int villageId, double consumptionAmount)
        {
            var record = new VillageConsumption {VillageId= villageId, ElectricityConsumption = consumptionAmount, Timestamp = DateTime.Now };
            Add(record).Wait();
            return;
        }


        public IEnumerable<object> GetAllVillage(int Duration)
        {
            List <VillageConsumption> villageConsumptions = this.GetAll().Include(x => x.Village).Where(x => x.Timestamp > DateTime.Now.AddHours(-Duration)).ToList();
            return villageConsumptions.GroupBy(y=>y.Village.Name)
                .Select(x => new { 
                    village_name = x.First().Village.Name, 
                    consumption = x.Sum(y=>y.ElectricityConsumption) 
                });
        }
    }
}
