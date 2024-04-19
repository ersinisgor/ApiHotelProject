using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
	public class CreateToken
	{
		public string TokenCreate()
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey securityKey = new SymmetricSecurityKey(bytes);
			SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			JwtSecurityToken token = new JwtSecurityToken(
							issuer: "https://localhost",
							audience: "https://localhost",
							notBefore: DateTime.Now,
							expires: DateTime.Now.AddSeconds(20),
							signingCredentials: signingCredentials
							);

			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			return handler.WriteToken(token);
		}

		public string TokenCreateAdmin()
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey securityKey = new SymmetricSecurityKey(bytes);
			SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			List<Claim> claims = new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Role, "admin"),
				new Claim(ClaimTypes.Role, "visitor")
			};

			JwtSecurityToken token = new JwtSecurityToken(
										issuer: "https://localhost",
										audience: "https://localhost",
										notBefore: DateTime.Now,
										expires: DateTime.Now.AddSeconds(20),
										signingCredentials: signingCredentials,
										claims: claims
										);


			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			return handler.WriteToken(token);
		}



	}
}
