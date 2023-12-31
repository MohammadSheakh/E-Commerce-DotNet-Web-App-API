using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Order
{
    public interface ICart<T, Id>
    {
        List<T> GetAll();
        List<T> GetByBuyerId(Id buyerId);
        T Create(T obj);
        T Update(T obj);
        bool Delete(Id id);
    }
}
