using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("users")]
    public class User
    {

    
        [Key]
        public int Id { get; set; }
        [Required]
        public long ChatId { get; set; }
        public int Step { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string? Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsAdmin { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public Room? Room { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? Phone { get; set; }
        public List<Outlay>? Outlays { get; set; }
        [NotMapped]
        public string? FullName => UserName ?? Name;
        public User(long chatId, string username)
        {
            ChatId = chatId;
            UserName = username;
        }
        public User()
        {

        }


    }
}
