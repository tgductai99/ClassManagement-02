using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using TaskQLLH.ClassRooms;

namespace TaskQLLH.ClassRooms.Dto
{
    [AutoMapTo(typeof(ClassRoom))]
    public class CreateClassroomDto
    {
        [Required]
        [StringLength(ClassRoom.MaxClassNameLength)]
        public string ClassName {get;set;}
        
        [Required]
        [StringLength(ClassRoom.MaxAcademicYearLength)]
        public string AcademicYear { get; set; }

        [StringLength(ClassRoom.MaxDescriptionLength)]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

