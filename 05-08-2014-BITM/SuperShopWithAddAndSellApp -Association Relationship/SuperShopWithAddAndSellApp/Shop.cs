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
           if(HasThisID(aNewProduct.ProductId))
            {
                UpdateQuantity(aNewProduct);
                return "product updated";
            }
           else
           {
               productList.Add(aNewProduct);
               return "product added";
           }
        }

        private bool HasThisID(string productId)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == productId)
                {
                    return true;
                }
            }
            return false;
        }


        private void UpdateQuantity(Product aNewProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == aNewProduct.ProductId)
                {
                    aProduct.Quantity += aNewProduct.Quantity;
                }
            }
        }


        public List<Product> GetProductList()
        {
            return productList;
        }


        public string SellProduct(Product aSellProduct)
        {
            if (HasThisIdInSell(aSellProduct.ProductId))
            {
               return SellQuantity(aSellProduct);
               // return "product updated";
            }
            else
            {
              //  productList.Add(aNewProduct);
                return "product is not found";
            }
        }

        private string SellQuantity(Product aSellProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductId == aSellProduct.ProductId)
                {
                    if (aProduct.Quantity >= aSellProduct.Quantity && aProduct.Quantity != 0)
                    {
                        aProduct.Quantity -= aSellProduct.Quantity;
                        return "product has been selled";
                    }
                    else
                    {
                        return "sorry, sell quqntity is not sufficient";
                    }
                }
            }
            return null;
        }

        private bool HasThisIdInSell(string productId)
        {
            foreach (Product aSellProduct in productList)
            {
                if (aSellProduct.ProductId == productId)
                {
                    return true;
                }
            }
            return false;
        }


       //private void SellQuantity(Product aNewProduct)
       // {
       //     foreach (Product aProduct in productList)
       //     {
       //         if (aProduct.ProductId == aNewProduct.ProductId)
       //         {
       //             aProduct.Quantity -= aNewProduct.Quantity;
       //         }
       //     }
       // }


        public List<Product> SellProductList()
        {
            return productList;
        }

        public List<Product> ShowProductList()
        {
            return productList;
        }
        //public string AddProduct(Product aNewProduct)
        //{
        //    foreach (Product aProduct in productList)
        //    {
        //        if (aProduct.ProductId == aNewProduct.ProductId)
        //        {
        //            aProduct.Quantity += aNewProduct.Quantity;
        //            return "product Updated";
        //        }

        //    }
        //    productList.Add(aNewProduct);
        //    return "succefully added";
        //}

        //public List<Product> GetProductList()
        //{
        //    return productList;
        //}

        //public string SellProduct(Product aNewProduct)
        //{
        //    foreach (Product aProduct in productList)
        //    {
        //        if (aProduct.ProductId == aNewProduct.ProductId)
        //        {
        //            aProduct.Quantity -= aNewProduct.Quantity;
        //            return "product Updated";
        //        }

        //    }
        //    //productList.Add(aNewProduct);
        //    return "succefully selled";
        //}

        //public List<Product> SellProductList()
        //{
        //    return productList;
        //}

    }
}
