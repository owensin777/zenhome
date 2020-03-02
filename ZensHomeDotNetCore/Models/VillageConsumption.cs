using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZensHomeDotNetCore.Models
{
    public class VillageConsumption
    {
        public int Id { get; set; }
        public double ElectricityConsumption { get; set; }
        public int VillageId { get; set; }
        public Village Village { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
