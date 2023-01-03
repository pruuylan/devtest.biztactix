using Domain.API;
using Domain.Interface;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileAPI _profileAPI;
        public ProfileService(IProfileAPI profileAPI)
        {
            _profileAPI = profileAPI;
        }

        public async Task<ProfileViewModel> GetProfile(string bearerToken)
        {
            try
            {
                return await _profileAPI.GetProfile(bearerToken);
            }
            catch (Exception ex)
            {
                return new ProfileViewModel();
            }
        }
        public async Task UpdateProfile(ProfileViewModel profile, string bearerToken)
        {
            await _profileAPI.UpdateProfile(profile, bearerToken);
        }
    }
}
