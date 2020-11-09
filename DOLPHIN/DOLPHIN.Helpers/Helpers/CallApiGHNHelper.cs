using DOLPHIN.Helpers.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
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
            string url = "https://dev-online-gateway.ghn.vn/shiip/public-api/master-data/province";

            var request = await this.CreateRequest(token);
            var result = await this.SendRequest(url, "GET", request);
            return result;
        }
        private async Task<string> SendRequest(string url, string httpMethod, string jsonData)
        {
            using var webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            webClient.Headers.Add("Token" , "98bb7369-1162-11eb-a23c-065c95c021cb");
            var responseData = await webClient.UploadStringTaskAsync(new Uri(url), httpMethod, jsonData);
            var result = responseData;

            return result;
        }

        private async Task<string> CreateRequest(string token)
        {
            return @"{

            }";
        }
    }
}
