using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.User
{
    public interface IUser<CLASS>
    {
        CLASS getUserByEmail(string senderEmail, string receiverEmail);
    }
}
