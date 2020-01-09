using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Authorization
{
    public interface ITokenService
    {
        JwtSecurityToken CreateToken(Models.Users.UserAuthDto userEntity);
        bool IsTokenValid(string token);
    }
}
