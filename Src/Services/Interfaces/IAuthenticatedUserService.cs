using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Services.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
