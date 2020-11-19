using DOLPHIN.DTO;
using DOLPHIN.Helpers.Interfaces;
using DOLPHIN.Service.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DOLPHIN.Service.Services
{
    /// <summary>
    /// AddressService.
    /// </summary>
    public class AddressService : IAddressService
    {
        private readonly ICallApiGHNHelper callApiGHNHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        /// <param name="callApiGHNHelper">callApiGHNHelper.</param>
        public AddressService(ICallApiGHNHelper callApiGHNHelper)
        {
            this.callApiGHNHelper = callApiGHNHelper;
        }

        /// <inheritdoc/>
        public async Task<List<AddressViewDto>> GetProvince(string token)
        {
            var response = await this.callApiGHNHelper.GetProvince(token);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            var province = new List<AddressViewDto>();

            foreach (var item in result?.data)
            {
                province.Add(new AddressViewDto
                {
                    Code = item.Code,
                    ProvinceID = item.ProvinceID,
                    ProvinceName = item.ProvinceName,
                });
            }

            return province;
        }

        public async Task<List<DistrictViewDto>> GetDistrict(string token, int provinceId)
        {
            var response = await this.callApiGHNHelper.GetDistrict(token, provinceId);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            var districts = new List<DistrictViewDto>();

            foreach (var item in result?.data)
            {
                districts.Add(new DistrictViewDto
                {
                    DistrictID = item.DistrictID,
                    ProvinceID = item.ProvinceID,
                    DistrictName = item.DistrictName,
                    Code = item.Code,
                    Type = item.Type,
                    SupportType = item.SupportType
                });
            }

            return districts;
        }

        public async Task<List<WardViewDto>> GetWard(string token, int districtId)
        {
            var response = await this.callApiGHNHelper.GetWard(token, districtId);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            var wards = new List<WardViewDto>();

            foreach (var item in result?.data)
            {
                wards.Add(new WardViewDto
                {
                    WardCode = item.WardCode,
                    DistrictID = item.DistrictID,
                    WardName = item.WardName
                });
            }

            return wards;
        }

        public async Task<List<OrderViewDto>> CreateOrder(string token, OrderRequestDto orderRequestDto)
        {
            var response = await this.callApiGHNHelper.CreateOrder(token, orderRequestDto);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            var orders = new List<OrderViewDto>();

            orders.Add(new OrderViewDto
            {
                ClientOrderCode = orderRequestDto.CliendOrderCode
            });
            //foreach (var item in result?.data)
            //{
            //    orders.Add(new OrderViewDto
            //    {
            //        ClientOrderCode = orderRequestDto.CliendOrderCode
            //        OrderCode = item.order_code,
            //        SortCode = item.sort_code,
            //        TotalFee = item.total_fee,
            //        ExpectedDeliveryTime = item.expected_delivery_time
            //    });
            //}

            return orders;
        }

        public async Task<List<TrackingOrderViewDto>> TrackingOrders(string orderCode)
        {
            var response = await this.callApiGHNHelper.TrackingOrdersByClient(orderCode);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            var trackingOrders = new List<TrackingOrderViewDto>();

            foreach (var item in result?.data)
            {
                trackingOrders.Add(new TrackingOrderViewDto
                {
                    Status = item.status
                });
            }

            return trackingOrders;
        }
    }
}
