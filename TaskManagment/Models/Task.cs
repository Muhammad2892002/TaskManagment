using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagment.Models
{
    public class Task
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ? Description { get; set; }


        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [ForeignKey("Status")]
        public long StatusId { get; set; }

        public Lookup Status { get; set; }

        [ForeignKey("user")]
        public long UserId { get; set; }
        public User user { get; set; }
    }
}
