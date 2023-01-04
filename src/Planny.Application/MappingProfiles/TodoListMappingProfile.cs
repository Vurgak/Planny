using AutoMapper;
using Planny.Application.Commands.TodoList;
using Planny.Application.ViewModels;
using Planny.Domain.Entities;

namespace Planny.Application.MappingProfiles;

public class TodoListMappingProfile : Profile
{
	public TodoListMappingProfile()
	{
		CreateMap<CreateTodoListCommand, TodoListEntity>()
			.ForMember(dest => dest.Id, opt => opt.Ignore())
			.ForMember(dest => dest.Guid, opt => opt.Ignore())
			.ForMember(dest => dest.Items, opt => opt.Ignore());

		CreateMap<TodoListEntity, TodoListViewModel>();
    }
}
