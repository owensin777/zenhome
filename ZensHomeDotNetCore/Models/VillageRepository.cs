using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public class VillageRepository : RepositoryBase<Village, MyDbContext>, IVillageRepository
    {
        public VillageRepository(MyDbContext Context) : base(Context)
        {

        }

        public void BookingVillageConsumption(int counterId, double consumptionAmount)
        {
            var record = new Village { ElectricityConsumption = 100, Timestamp = new DateTime(), Name = "abc" };
            Add(record).Wait();
            return;
        }


        IEnumerable<Village> IVillageRepository.GetAllVillage()
        {
            return this.GetAll().Result;
        }

        Village IVillageRepository.GetVillageById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
