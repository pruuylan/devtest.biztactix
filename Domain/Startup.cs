using Domain.API;
using Domain.Interface;
using Domain.Model;
using Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;

namespace Domain
{
    public static class Startup
    {
        public static void InitDomain(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<ProfileViewModel>();

            services.AddRefitClient<IAuthenticateAPI>()
                    .ConfigureHttpClient(a => a.BaseAddress = new Uri("https://api.devreg.org/api/v1"))
                    .SetHandlerLifetime(TimeSpan.FromSeconds(90));

            services.AddRefitClient<IProfileAPI>()
                    .ConfigureHttpClient(a => a.BaseAddress = new Uri("https://api.devreg.org/api/v1"))
                    .SetHandlerLifetime(TimeSpan.FromSeconds(90));
            //.AddHttpMessageHandler<AuthorizationMessageHandler>()
        }
    }
}
