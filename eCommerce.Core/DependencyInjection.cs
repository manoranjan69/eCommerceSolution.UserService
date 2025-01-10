using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContract;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.Core.Services;
using FluentValidation;
using eCommerce.Core.Validator;


namespace eCommerce.Core;

public static class DependencyInjection
{
    // <summary>
    //Extension method  to add infrastructure  services to dependedency injection container.
    // </summary>
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        //To do :Add  Services to  the IOC container 
        //Core Services often include data  access,caching and other low -level Components.

       

        services.AddScoped<IUserService, UserService>();
        services.AddValidatorsFromAssemblyContaining<LoginRequestValidators>();
        return services;

    }
}