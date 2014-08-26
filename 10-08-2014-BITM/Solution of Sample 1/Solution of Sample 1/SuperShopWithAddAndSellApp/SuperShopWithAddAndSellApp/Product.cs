namespace SuperShopWithAddAndSellApp
{
    public class Product
    {
        private string productId;
        private int quantity;

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }

        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product(string productId, int quantity) : this()
        {
            this.productId = productId;
            this.quantity = quantity;
        }

        public Product()
        {
            
        }

    }
}
