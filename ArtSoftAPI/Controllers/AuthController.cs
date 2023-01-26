using ArtSoftAPI.Data.Model;
using ArtSoftAPI.ProxyClases.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FeedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto req)
        {
            CreatePasswordHash(req.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.UserName = req.UserName;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto req) 
        {
            string token = string.Empty;

            if (user.UserName != req.UserName)
            {
                return BadRequest("User not found");
            }

            if (!VerifyPasswordHash(req.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Wrong password");
            }

            token = CreateToken(user);
            return Ok(token);
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash,  byte[] passwordSalt) 
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                return computedHash.SequenceEqual(passwordHash); 
            }
        }
        private string CreateToken(User user)
        {
            
            List<Claim> claims = new List<Claim> 
            {
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: cred
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
