
using API.CORE.Dto;
using API.CORE.Entities;
using System.Data.SqlTypes;

namespace API.CORE
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest authenticateRequest);
    
        User  GetById(int id );

    }
}