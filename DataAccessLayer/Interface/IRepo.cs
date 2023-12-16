using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    // generic interface 
    public interface IRepo<CLASS, IdDataType, RetDataType>
    {
        List<CLASS> Get();
        CLASS Get(IdDataType id);
        RetDataType Create(CLASS obj);
        RetDataType Update(CLASS obj);
        bool Delete(IdDataType id);
    }
}
