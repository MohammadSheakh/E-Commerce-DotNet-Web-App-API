using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.SellerProfile
{
    public interface ISellerProfile<CLASS>
    {
        CLASS UpdateShopProfileIdToNull(int userId);

    }
}
