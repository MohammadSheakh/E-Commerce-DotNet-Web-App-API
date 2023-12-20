using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Conversations
{
    public class Message
    {
        public int Id { get; set; }

        public string SenderEmail { get; set; }

        public string ReceiverEmail { get; set; }

        public int? ConversationId { get; set; }

        public string MessageDetails {  get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
