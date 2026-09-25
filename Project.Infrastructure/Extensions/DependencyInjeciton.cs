using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Extentsions;

public static class DependencyInjeciton
{
    public static IServiceCollection AddAppDbcontext(
        this IServiceCollection services,
        IConfiguration configuration)
        {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connectionString))
        throw new InvalidOperationException("Connection string 'DefaultConnection' was not found.");



        services.AddDbContext<AppDbcontext>(opitons =>
        opitons.UseSqlite(connectionString));


        return services;
        
    }
    
}

