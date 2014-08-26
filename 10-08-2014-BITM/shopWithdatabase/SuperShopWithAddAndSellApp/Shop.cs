using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopWithAddAndSellApp
{
    public class Shop
    {
        private string shopName = "";
        private string shopAddress = "";

       public List<Product> productList;

        public string ShopName
        {
            get { return shopName; }

        }

        public string ShopAddress
        {
            get { return shopAddress; }

        }

        public Shop(string shopName, string shopAddress) : this()
        {
            this.shopName = shopName;
            this.shopAddress = shopAddress;
        }

        public Shop()
        {
            productList = new List<Product>();
        }

        public string AddProduct(Product aNewProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == aNewProduct.ProductId)
                {
                    aProduct.Quantity += aNewProduct.Quantity;
                    return "product Updated";
                }

            }
            productList.Add(aNewProduct);
            return "succefully added";
        }

        public string SellProduct(Product aNewProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == aNewProduct.ProductId)
                {
                    bool isSuccess = aProduct.DeductQuantity(aNewProduct.Quantity);
                    if (!isSuccess)
                    {
                        return "Insuficient quantity";
                    }

                    return "Sell success";
                }
            }
            return "success";

            //public List<Product> GetProductList()
            //{
            //    return productList;
            //}
        }
    }
}
