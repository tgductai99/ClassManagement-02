using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace TaskQLLH.Classrooms.Dto
{
    [AutoMapFrom(typeof(Classroom))]
    public class ClassroomDto : EntityDto<int>
    {
        public string ClassName { get; set; }
        public string AcademicYear { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}