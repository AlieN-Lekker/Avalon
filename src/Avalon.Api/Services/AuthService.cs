using Avalon.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Avalon.Api.Services
{
    public class AuthService
    {
        private readonly MongoDbContext _db;
        private readonly IConfiguration _config;

        public AuthService(MongoDbContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }

        public string? Login(string userName, string password)
        {
            var user = _db.Users.Find(u => u.UserName == userName && u.Password == password).FirstOrDefault();
            if (user == null) return null;

            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"] ?? "secret");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, userName) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
