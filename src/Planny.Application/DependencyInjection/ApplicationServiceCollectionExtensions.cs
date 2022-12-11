using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Planny.Application.DependencyInjection;

public static class ApplicationServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();

        services.AddAutoMapper(executingAssembly);
        services.AddMediatR(executingAssembly);
    }
}
