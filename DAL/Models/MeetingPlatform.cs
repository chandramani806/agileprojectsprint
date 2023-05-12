using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.DAL.Models
{
    public class MeetingPlatform
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
