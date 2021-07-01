using Aduaba.DTO;
using Aduaba.DTO.Account;
using Aduaba.DTOPresentation.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Services.Interfaces
{
    public interface IUserServices
    {
        Task<string> RegisterAsync(RegisterRequest model);
        Task<string> UpdateAsync(UpdateRequest model);
        Task<string> DeleteAsync();
        Task<AuthenticationResponse> LoginAsync(LoginRequest model);
        Task<AuthenticationResponse> RefreshTokenAsync(string token);
        public bool RevokeRefreshToken(string token);
        //Task<string> LogoutAsync();
    }
}
