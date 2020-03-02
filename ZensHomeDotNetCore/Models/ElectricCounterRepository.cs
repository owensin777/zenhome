using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ZensHomeDotNetCore.Data;

namespace ZensHomeDotNetCore.Models
{
    public class ElectricCounterRepository:IElectricCounterRepository
    {
        private readonly IConfiguration mConfiguration;
        public ElectricCounterRepository (IConfiguration Configuration)
        {
            mConfiguration = Configuration;
        }
        public async Task<Village> GetVillageByCounterIdAsync(int Id)
        {
            //Call API
            var baseUrl = mConfiguration.GetSection("CounterInfoApiUrl").Value;
            HttpClient httpclient = new HttpClient();
            using (HttpResponseMessage res = await httpclient.GetAsync(baseUrl+Id))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ElectricCounter>(data).Village;
            }
        }
    }
}
