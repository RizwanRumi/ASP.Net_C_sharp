using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superShopAPP
{
    class Product
    {
        private string productId = "";
        private int quantity;

        public string ProductId
        {
            get { return productId; }

        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product(string productId, int quantity)
            : this()
        {
            this.productId = productId;
            this.quantity = quantity;
        }

        public Product() { }
        //private const int totalQuqntity = 0;


    }
}
