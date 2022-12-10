using API.CORE;
using API.CORE.Dto;
using API.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.DATA
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appsettings)
        {
            this._appSettings = appsettings.Value;
        }

        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
        };

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Username == model.UserName && model.Password == x.Password);
            if (user == null) 
            {
                return null;

              }

            //auhten seccess -->  jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);


        }

        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);


            var tokenDesc = new SecurityTokenDescriptor
            {  
                Subject = new System.Security.Claims.ClaimsIdentity(new[] 
                { 
                    new Claim("id", user.Id.ToString()),
                    new Claim("name", user.Username.ToString()),

                }
                ),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials =  new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDesc);

            return tokenHandler.WriteToken(token);

        }
 
        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);

        }

         
    }
}