using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Tier3Slit.Communication;

namespace Tier3Slit.Models.Handlers.Interfaces
{
    interface IUserHandler
    {
        string RegisterUser(Message message);
        string ChangePassword(Message Message);
        string Login(Message message);
        string GetInfo(string Username);
        string GenerateSalt(RNGCryptoServiceProvider rng, int size);

    }
}
