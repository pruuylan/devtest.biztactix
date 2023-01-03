using Domain.API;
using Domain.Interface;
using Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IAuthenticateAPI _authenticateAPI;

        public AuthenticateService(IAuthenticateAPI authenticateAPI)
        {
            _authenticateAPI = authenticateAPI;
        }

        public async Task<string> Authenticate(string creds)
        {
            return await _authenticateAPI.Authenticate(creds);
        }
    }
}
