using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZensHomeDotNetCore.Models
{
    public class Village
    {
        public int Id { get; set; }
        public string Name{ get; set;}
        public double ElectricityConsumption { get; set; }
        public List<ElectricCounter> ElectricCounter { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
