using System.ComponentModel.DataAnnotations;

namespace agileprojectsprint.DAL.Models
{
    public class Sprint
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

    }
}
