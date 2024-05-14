using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Room
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int RoomId { get; set; }
        [MinLength(2)]public string RoomName { get; set; }
       
    }
}
