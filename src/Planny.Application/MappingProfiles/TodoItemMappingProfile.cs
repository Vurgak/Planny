using AutoMapper;
using Planny.Application.Commands.TodoItem;
using Planny.Domain.Entities;

namespace Planny.Application.MappingProfiles;

public class TodoItemMappingProfile : Profile
{
	public TodoItemMappingProfile()
    {
        CreateMap<CreateTodoItemCommand, TodoItemEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Guid, opt => opt.Ignore())
            .ForMember(dest => dest.Description, opt => opt.NullSubstitute(string.Empty))
            .ForMember(dest => dest.ListId, opt => opt.Ignore())
            .ForMember(dest => dest.List, opt => opt.Ignore());
    }
}
