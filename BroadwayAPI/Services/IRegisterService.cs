using BroadwayAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Services
{
    public interface IRegisterService
    {
        Task RegisterAsync(ApplicationUser model);
    }
}
