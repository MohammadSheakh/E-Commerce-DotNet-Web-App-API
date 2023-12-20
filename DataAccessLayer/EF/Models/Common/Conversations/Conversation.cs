using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Conversations
{
    public class Conversation
    {
        public int Id { get; set; }

        public string ParticipantsEmail { get; set; }

        public string LastMessage { get; set; }

        public DateTime? CreatedAt { get; set; }


    }
}
