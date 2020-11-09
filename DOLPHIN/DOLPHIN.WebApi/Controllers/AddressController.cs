using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOLPHIN.DTO;
using DOLPHIN.WebApi.Enums;
using DOLPHIN.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace DOLPHIN.WebApi.Controllers
{
    public class AddressController : Controller
    {
        [HttpGet]
        public async Task<ApiResponse<AddressViewDto>> GetProvince()
        {
            try
            {
                string token = "98bb7369-1162-11eb-a23c-065c95c021cb";
                return new ApiResponse<AddressViewDto>(EnStatusApiReponse.Success, await this.groupService.GetGroupByName(token);
            }
            catch (Exception ex)
            {
                this.logger.LogError(new EventId(0), ex, ex.GetBaseException().Message + '\n' + ex.GetBaseException().StackTrace);
                return new ApiResponse<GroupViewModelDto>(ex.HResult);
            }
        }
    }
}
