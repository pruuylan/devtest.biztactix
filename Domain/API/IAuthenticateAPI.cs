using Domain.Model;
using Refit;
using System.Threading.Tasks;

namespace Domain.API
{
    [Headers("Content-Type: application/json")]
    public interface IAuthenticateAPI
    {
        [Post("/auth/userlogin")]
        Task<string> Authenticate([Body] string creds);
    }
}
