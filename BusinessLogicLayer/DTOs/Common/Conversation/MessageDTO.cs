using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Conversation
{
    public class MessageDTO
    {
        public int Id { get; set; }

        [Required]
        public string SenderEmail { get; set; }

        [Required]
        public string ReceiverEmail { get; set; }

        [Required]
        public int? ConversationId { get; set; }

        [Required]
        public string MessageDetails { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
