using BroadwayAPI.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BroadwayAPI.CommonServices
{
    public interface IAuthorization
    {
        AuthResultant GenerateTokens(string username, Claim[] claims, DateTime now);
    }
}
