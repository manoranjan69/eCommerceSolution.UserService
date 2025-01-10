using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Metadata.Ecma335;


namespace eCommerce.Infrastructure;
public static class DependencyInjection
{
   // <summary>
   //Extension method  to add infrastructure  services to dependedency injection container.
  // </summary>
    public static IServiceCollection AddInfrastruction(this IServiceCollection services) 
    {
        //To do :Add  Services to  the IOC container 
        //Infrastructure Services often include data  access,caching and other low -level Components.

        services.AddTransient<IUsersRepository, UserRepository>();
        services.AddTransient<DapperDbContext>();
        return services;
    
    }



}

