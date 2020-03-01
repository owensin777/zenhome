using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZensHomeDotNetCore.Models
{
    public interface IElectricCounterRepository
    {
        Village GetVillageByCounterId(int id);
    }
}
