using System.Collections.Generic;

namespace SuperShopWithAddAndSellApp
{
    public class Shop
    {
        private string shopName = "";
        private string shopAddress = "";

        List<Product> productList;

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

        public string SellProduct(Product aSellProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == aSellProduct.ProductId)
                {
                    aProduct.Quantity -= aSellProduct.Quantity;
                    return "Product Sold!";
                }
            }
            return "The product does not exists!";
        }
        public List<Product> GetProductList()
        {
            return productList;
        }

    }
}
