using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.ECommerce.Abstract;

namespace w06.ECommerce.Concrete
{
    public class CustomerAction : ICustomerAction
    {
        public void SearchProduct(string keywords)
        {
            throw new NotImplementedException();
        }

        public void ViewProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public void AddToCart(string productId)
        {
            throw new NotImplementedException();
        }

        public void Checkout()
        {
            throw new NotImplementedException();
        }
    }
}
