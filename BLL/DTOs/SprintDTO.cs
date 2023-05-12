using agileprojectsprint.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.BLL.DTOs
{
    public class SprintDTO
    {

        [Key]
        [MaxLength(10)]
        public int SprintId { get; set; }
        [StringLength(8)]
        public string SprintName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(10)]
        public int ProjectCode { get; set; }
        public DateTime CreatedOn { get; set; }


        public static explicit operator Sprint(SprintDTO dto)
        {
            if (dto == null)
                return null;

            return new Sprint
            {
                SprintId = dto.SprintId,
                SprintName = dto.SprintName,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                ProjectCode = dto.ProjectCode,
                CreatedOn = dto.CreatedOn

            };
        }

        public static implicit operator SprintDTO(Sprint meet)
        {
            if (meet == null)
                return null;

            return new SprintDTO
            {
                SprintId = meet.SprintId,
                SprintName = meet.SprintName,
                StartDate = meet.StartDate,
                EndDate = meet.EndDate,
                ProjectCode = meet.ProjectCode,
                CreatedOn = meet.CreatedOn

            };
        }
    }
}
