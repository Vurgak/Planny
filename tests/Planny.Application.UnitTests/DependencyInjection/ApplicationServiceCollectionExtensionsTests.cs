using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Planny.Application.DependencyInjection;

namespace Planny.Application.UnitTests.DependencyInjection;

public class ApplicationServiceCollectionExtensionsTests
{
    [Fact]
    public void AddApplication_ShouldRegisterServiceForIMapper()
    {
        var services = new ServiceCollection();
        services.AddApplication();

        var serviceProvider = services.BuildServiceProvider();

        var service = serviceProvider.GetService<IMapper>();

        Assert.NotNull(service);
    }

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