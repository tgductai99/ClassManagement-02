using Abp.Application.Services.Dto;

namespace TaskQLLH.Classrooms.Dto
{
    public class PagedClassroomResultRequestDto : PagedResultRequestDto
    {
        public string Keyword {get; set;}
        public bool? IsActive { get; set; }
        public string AcademicYear { get; set; }
        
        public string Sorting { get; set; }
    }
}

