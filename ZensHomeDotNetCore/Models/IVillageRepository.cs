using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public interface IVillageRepository
    {
        Village GetVillageById(int id);

        IEnumerable<Village> GetAllVillage();

        void BookingVillageConsumption(int counterId, double consumptionAmount);
    }
}
