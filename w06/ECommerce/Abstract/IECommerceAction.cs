using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.ECommerce.Abstract
{
    public interface IECommerceAction
    {
        void SearchProduct(string keywords);
        void ViewProduct(string productId);

    }
}
