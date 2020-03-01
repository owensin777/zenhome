using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public interface IElectricCounterRepository: IRepository<ElectricCounter>
    {
        Village GetVillageByCounterId(int id);
    }
}
