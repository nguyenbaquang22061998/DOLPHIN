using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOLPHIN.Helpers.Interfaces
{
    public interface ICallApiGHNHelper 
    {
        Task<string> GetProvince(string token);
    }
}
