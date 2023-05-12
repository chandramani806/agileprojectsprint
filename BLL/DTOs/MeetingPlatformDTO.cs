using agileprojectsprint.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.BLL.DTOs
{
    public class MeetingPlatformDTO
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public static explicit operator MeetingPlatform(MeetingPlatformDTO dto)
        {
            if (dto == null)
                return null;

            return new MeetingPlatform
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }

        public static implicit operator MeetingPlatformDTO(MeetingPlatform meet)
        {
            if (meet == null)
                return null;

            return new MeetingPlatformDTO
            {
                Id = meet.Id,
                Name = meet.Name

            };
        }
    }
}
