using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Planny.Application.DependencyInjection;

namespace Planny.Application.UnitTests;

public class ApplicationServiceCollectionExtensionsTests
{
    [Fact]
    public void AddApplication_ShouldRegisterServiceForIMediator()
    {
        var services = new ServiceCollection();
        services.AddApplication();

        var serviceProvider = services.BuildServiceProvider();

        var service = serviceProvider.GetService<IMediator>();

        Assert.NotNull(service);
    }
}