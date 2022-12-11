using AutoMapper;
using System.Runtime.Serialization;

namespace Planny.Application.UnitTests.MappingProfiles;

public abstract class MappingProfileTests<TProfile> where TProfile: Profile, new()
{
    protected readonly IConfigurationProvider Configuration;
    protected readonly IMapper Mapper;

    public MappingProfileTests()
    {
        Configuration = new MapperConfiguration(config => config.AddProfile<TProfile>());
        Mapper = Configuration.CreateMapper();
    }

    protected object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        return FormatterServices.GetUninitializedObject(type);
    }
}
