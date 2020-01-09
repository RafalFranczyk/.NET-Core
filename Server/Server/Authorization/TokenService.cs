using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Server.Models.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Server.Authorization
{
    public class TokenService : ITokenService
    {
        private ILogger<TokenService> logger;
        private readonly IOptions<JwtAuthentication> jwtAuthentication;

        public TokenService(IOptions<JwtAuthentication> jwtAuthentication, ILogger<TokenService> logger)
        {
            this.jwtAuthentication = jwtAuthentication;
            this.logger = logger;
        }

        public JwtSecurityToken CreateToken(UserAuthDto userEntity)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userEntity.Username)
                };

                //var creds = jwtAuthentication.Value.SigningCredentials;

                var token = new JwtSecurityToken(
                    issuer: jwtAuthentication.Value.ValidIssuer,
                    audience: jwtAuthentication.Value.ValidAudience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMonths(1));

                return token;
            }
            catch (Exception ex)
            {
                logger.LogCritical("Failed to create JWT token.", ex.ToString());

                throw;
            }
        }

        public bool IsTokenValid(string token)
        {
            throw new NotImplementedException();
        }
    }
}
