using agileprojectsprint.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.BLL.DTOs
{
    public class MeetingDTO
    {


        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
        [StringLength(200)]
        public string MeetingLink { get; set; }

        public DateTime MeetingDate { get; set; }
        public DateTime MeetingTime { get; set; }
        [StringLength(20)]
        public string MeetingType { get; set; }
        [MaxLength(10)]
        public int SprintId { get; set; }
        [StringLength(8)]
        public string MeetingPassword { get; set; }
        public DateTime CreatedOn { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(10)]
        public int MeetingPlatformId { get; set; }

        public static explicit operator Meeting(MeetingDTO dto)
        {
            if (dto == null)
                return null;

            return new Meeting
            {
                Id = dto.Id,
                MeetingLink = dto.MeetingLink,
                MeetingDate = dto.MeetingDate,
                MeetingTime = dto.MeetingTime,
                MeetingType = dto.MeetingType,
                SprintId = dto.SprintId,
                MeetingPassword = dto.MeetingPassword,  
                CreatedOn = dto.CreatedOn,
                Status = dto.Status,
                UpdatedOn = dto.UpdatedOn,
                MeetingPlatformId = dto.MeetingPlatformId

               
            };
        }

        public static implicit operator MeetingDTO(Meeting meet)
        {
            if (meet == null)
                return null;

            return new MeetingDTO
            {
                Id = meet.Id,
                MeetingLink = meet.MeetingLink,
                MeetingDate = meet.MeetingDate,
                MeetingTime = meet.MeetingTime,
                MeetingType = meet.MeetingType,
                SprintId = meet.SprintId,
                MeetingPassword = meet.MeetingPassword,
                CreatedOn = meet.CreatedOn,
                Status = meet.Status,
                UpdatedOn = meet.UpdatedOn,
                MeetingPlatformId = meet.MeetingPlatformId
                
            };
        }
    }
}
