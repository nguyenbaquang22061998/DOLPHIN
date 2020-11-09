using DOLPHIN.DTO;
using DOLPHIN.Helpers.Interfaces;
using DOLPHIN.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Services
{
    public class AddressService : IAddressService
    {
        private readonly ICallApiGHNHelper callApiGHNHelper;

        public AddressService(ICallApiGHNHelper callApiGHNHelper)
        {
            this.callApiGHNHelper = callApiGHNHelper;
        }

        public async Task<AddressViewDto> GetProvinceAsy(string token)
        {
            var response = await this.callApiGHNHelper.GetProvince(token);
            var result = JsonConvert.DeserializeObject<dynamic>(response);

            return await result;
        }

        //public async List<AddressViewDto> GetProvince(string stringReponse)
        //{
        //    var province = new List<AddressViewDto>();

        //    foreach (var item in stringReponse)
        //    {
        //        province.Add(new AddressViewDto
        //        {
        //            Code = item.data?.Code,
        //            ProvinceID = item.data?.ProvinceID,
        //            ProvinceName = item.data?.ProvinceName,
        //        });
        //    }
        //}
    }
}
