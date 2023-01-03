using Domain.Model;
using Refit;
using System.Threading.Tasks;

namespace Domain.API
{
    [Headers("Content-Type: application/json")]
    public interface IProfileAPI
    {
        [Get("/profile")]
        Task<ProfileViewModel> GetProfile([Header("Authorization")] string bearerToken);

        [Put("/profile")]
        Task UpdateProfile(ProfileViewModel profile, [Header("Authorization")] string bearerToken);
    }
}
