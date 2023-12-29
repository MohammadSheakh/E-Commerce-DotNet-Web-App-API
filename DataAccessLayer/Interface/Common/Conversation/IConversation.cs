using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Conversation
{
    public interface IConversation<CLASS>
    {
        List<CLASS> ShowAllConversationByLoggedInUserEmail(string currentLoggedInUserEmail);

    }
}
