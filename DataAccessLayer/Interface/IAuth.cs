using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IAuth<ReturnDataType> // Return data type ta dynamic rakhtesi 
    {
        // interface public korte hobe 
        ReturnDataType Authenticate(string email, string password);

    }
}
