using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.User
{
    public interface IUser<CLASS>
    {
        bool getUserByEmail(string senderEmail, string receiverEmail);
        CLASS UpdateSellerProfileIdToNull(int userId);
    }
}
