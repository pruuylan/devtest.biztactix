using Domain.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IProfileService
    {
        Task<ProfileViewModel> GetProfile(string bearerToken);
        Task UpdateProfile(ProfileViewModel profile, string bearerToken);
    }
}
