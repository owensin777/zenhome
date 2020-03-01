using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public class ElectricCounterRepository : RepositoryBase<ElectricCounter, MyDbContext>
    {
        public ElectricCounterRepository(MyDbContext Context): base(Context)
        { 
           
        }
        public Village GetVillageByCounterId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
