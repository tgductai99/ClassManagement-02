using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace TaskQLLH.ClassRooms
{
    public class ClassRoom : FullAuditedEntity<int>
    {
        public const int MaxClassNameLength = 50;
        public const int MaxAcademicYearLength = 20;
        public const int MaxDescriptionLength = 500;

        [Required]
        [StringLength(MaxClassNameLength)]
        public string ClassName { get; set; }
        
        [Required]
        [StringLength(MaxAcademicYearLength)]
        public string AcademicYear { get; set; }
        
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
        
        public bool IsActive { get; set; }

        public ClassRoom()
        {
            IsActive = true;
        }
    }
}