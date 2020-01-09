using Server.Models.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<UserInfoDto> WithoutPasswords(this IEnumerable<UserInfoDto> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static UserInfoDto WithoutPassword(this UserInfoDto user)
        {
            user.Password = null;
            return user;
        }
    }
}
