using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

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


        IEnumerable<VillageConsumption> IVillageConsumptionRepository.GetAllVillage(int Duration)
        {
            return this.GetAll().Result.Where(x=>x.Timestamp> DateTime.Now.AddHours(-Duration));
        }

        //VillageConsumption IVillageConsumptionRepository.GetVillageById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
