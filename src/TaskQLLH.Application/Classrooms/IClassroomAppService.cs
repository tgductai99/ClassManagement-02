using Abp.Application.Services;
using Abp.Application.Services.Dto; 
using TaskQLLH.Classrooms.Dto;

namespace TaskQLLH.Classrooms
{
    public interface IClassroomAppService : IAsyncCrudAppService<
        ClassroomDto, 
        int,
        PagedClassroomResultRequestDto, 
        CreateClassroomDto, 
        UpdateClassroomDto
    >
    {
    
    }
}