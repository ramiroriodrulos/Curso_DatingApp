using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        /*El JWT devolverá un sting*/
        string CreateToken (AppUser user);
    }
}