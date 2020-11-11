using DOLPHIN.Helpers.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Helpers.Helpers
{
    public class CallApiGHNHelper : ICallApiGHNHelper
    {
        private readonly IConfiguration configs;
        private readonly string ghnUrl;


        public CallApiGHNHelper(IConfiguration configs)
        {
            this.configs = configs;
            this.ghnUrl = this.configs["GhnUrl"];
        }

        public async Task<string> GetProvince(string token)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(ghnUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("token", "98bb7369-1162-11eb-a23c-065c95c021cb");

            // List data response.
            var response = await client.GetAsync("/shiip/public-api/master-data/province");
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

        public async Task<string> GetDistrict(string token, int provinceId)
        {
            var notiRequest = new
            {
                province_id = provinceId
            };
            var json = JsonConvert.SerializeObject(notiRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            client.BaseAddress = new Uri(ghnUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("token", "98bb7369-1162-11eb-a23c-065c95c021cb");

            // List data response.
            var response = await client.PostAsync("/shiip/public-api/master-data/district", data);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

        public async Task<string> GetWard(string token, int districtId)
        {
            var notiRequest = new
            {
                district_id = districtId
            };
            var json = JsonConvert.SerializeObject(notiRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            client.BaseAddress = new Uri(ghnUrl);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("token", "98bb7369-1162-11eb-a23c-065c95c021cb");

            // List data response.
            var response = await client.PostAsync("/shiip/public-api/master-data/ward?district_id", data);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

        private async Task<StringContent> CreateRequest(int provinceId)
        {
            var notiRequest = new
            {
                province_id = provinceId
            };
            var json = JsonConvert.SerializeObject(notiRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}
