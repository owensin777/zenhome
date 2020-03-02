using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public interface IVillageConsumptionRepository
    {
        //VillageConsumption GetVillageById(int Dd);

        IEnumerable<VillageConsumption> GetAllVillage(int Duration);

        void BookingVillageConsumption(int VillageId, double ConsumptionAmount);
    }
}
