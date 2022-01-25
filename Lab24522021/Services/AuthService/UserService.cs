using Laborator54522021.Models;
using Laborator54522021.Models.DTOs;
using Licenta.Data;
using Licenta.Utilities.JWTutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Licenta.Services.AuthService
{
    public class UserService : IUserService
    {
        public Context context;
        public IJWTUtils iJWTUtils; 
       
        public UserResponseDTO Authentificate(UserRequestDTO model)
        {
            var user = context.Users.FirstOrDefault(x => x.Username == model.Username);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }
            //JWT generation (Json Web Token)
            var jwtToken = iJWTUtils.GenerateJWTToken(user);
            return new UserResponseDTO(user, jwtToken);
        }
        
        public IEnumerable<User> GetAllUsers()
        {
           // var users = context.Users;
           // return users;
           // return
          throw new NotImplementedException();
           //return context.Users;
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
