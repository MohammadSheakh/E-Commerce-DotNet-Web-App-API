using DataAccessLayer.EF.Models.Product.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Product.Specificaiton
{
    public interface ISpecificationCategory<SpecificationCategory, Specification>
    {
        Specification AddSpecification(Specification obj);
        SpecificationCategory AddSpecificationCategory(SpecificationCategory obj);
        
    }
}
