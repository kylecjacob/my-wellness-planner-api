using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MyWellnessPlannerApi.Options;
using MyWellnessPlannerApi.Services.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyWellnessPlannerApi.Services.Implementations
{
    public class TokenService : ITokenService
    {
		private readonly TokenOptions Configuration;
		
		public TokenService(IOptions<TokenOptions> configuration)
        {
			Configuration = configuration.Value;
        }
		public string GenerateToken(string username)
		{
			var mySecret = Configuration.Secret;
			var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecret));

			var myIssuer = Configuration.Isssuer;
			var myAudience = Configuration.Audience;

			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.NameIdentifier, username.ToString()),
				}),
				Expires = DateTime.UtcNow.AddDays(1),
				Issuer = myIssuer,
				Audience = myAudience,
				SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
			};

			var token = tokenHandler.CreateToken(tokenDescriptor);
			return tokenHandler.WriteToken(token);
		}
	}
}
