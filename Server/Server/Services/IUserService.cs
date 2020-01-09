using Server.Helpers;
using Server.Models.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public interface IUserService
    {
        UserInfoDto Authenticate(string username, string password);
        IEnumerable<UserInfoDto> GetAll();
    }
}
