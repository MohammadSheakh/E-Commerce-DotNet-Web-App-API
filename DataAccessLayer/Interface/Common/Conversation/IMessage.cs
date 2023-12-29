using DataAccessLayer.EF.Models.Common.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Conversation
{
    public interface IMessage<CLASS>
    {
        List<Message> GetAllMessageByConversationId(int conversationId);

        bool DeleteAllMessageByConversationId(int conversationId);
    }
}
