using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.DAL.Models
{
    public class Meeting
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
        [StringLength(200)]
        public string MeetingLink { get; set; }

        public DateTime MeetingDate { get; set; }
        public DateTime MeetingTime { get; set; }
        [StringLength (20)]
        public string MeetingType { get; set;}
        [MaxLength(10)]
        public int SprintId { get; set; }
        [StringLength(8)]
        public string MeetingPassword { get; set;}
        public DateTime CreatedOn { get; set; }
        [StringLength(20)]
        public string Status { get; set;}
        public DateTime UpdatedOn { get; set; }
        [MaxLength(10)]
        public int MeetingPlatformId { get; set; }

    }
}
