using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planny.Application.Shared.Abstractions;
using Planny.Infrastructure.DependencyInjection;

namespace Planny.Infrastructure.UnitTests.DependencyInjection;

public class InfrastructureServiceCollectionExtensionsTests
{
    private readonly IConfiguration _configuration;

    public InfrastructureServiceCollectionExtensionsTests()
    {
        var configuration = new Dictionary<string, string>
        {
            { "ConnectionStrings:ApplicatonDb", "" },
        };

        _configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(configuration!)
            .Build();
    }

    [Fact]
    public void AddInfrastructure_ShouldRegisterServiceForIApplicationDbContext()
    {
        var services = new ServiceCollection();
        services.AddInfrastructure(_configuration);

        var serviceProvider = services.BuildServiceProvider();

        var service = serviceProvider.GetService<IApplicationDbContext>();

        Assert.NotNull(service);
    }
}