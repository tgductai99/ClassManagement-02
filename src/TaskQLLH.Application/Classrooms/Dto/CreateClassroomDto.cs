using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using TaskQLLH.Classrooms;

namespace TaskQLLH.Classrooms.Dto
{
    [AutoMapTo(typeof(Classroom))]
    public class CreateClassroomDto
    {
        [Required]
        [StringLength(Classroom.MaxClassNameLength)]
        public string ClassName {get;set;}
        
        [Required]
        [StringLength(Classroom.MaxAcademicYearLength)]
        public string AcademicYear { get; set; }

        [StringLength(Classroom.MaxDescriptionLength)]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

