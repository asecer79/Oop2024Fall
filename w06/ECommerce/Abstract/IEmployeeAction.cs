using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.ECommerce.Abstract
{
    public interface IEmployeeAction:IECommerceAction,ICustomerAction//multiple interface inheritance
    {
        void AddNewProduct(string productId, string name);
        void UpdateProduct(string productId, string name);
    }
}
