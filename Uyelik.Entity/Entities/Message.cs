using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uyelik.Entity.IdentityModels;

namespace Uyelik.Entity.Entities
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public DateTime MessageDate { get; set; } = DateTime.Now;
        [Required]
        public string Content { get; set; }
        [Required]
        public string SendBy { get; set; }//Gonderenin ID si (bu sistemde id string tanımlanmış)
        [Required]
        public string SendTo { get; set; }

        [ForeignKey("SendBy")]
        public virtual ApplicationUser Sender { get; set; }

    }
}
