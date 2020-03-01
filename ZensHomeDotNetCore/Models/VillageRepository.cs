using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZensHomeDotNetCore.Models
{
    public class VillageRepository : IVillageRepository
    {
        public void BookingVillageConsumption(int counterId, double consumptionAmount)
        {
            throw new NotImplementedException();
        }

        public void GetAllVillage()
        {
            //get from DB ...
        }

        public void GetVillageById(int id)
        {
            //get from db by id

        }
    }
}
