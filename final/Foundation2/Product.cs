using System;

namespace OnlineOrdering
{
    public class Product
    {
        private string _productName;
        private string _productID;
        private int _price;
        private int _quantityProduct;
        
        public string Productname { get => _productName; set => _productName = value; }
        public string ProductID {get => _productID; set => _productID = value; }
        public decimal Price {get => _price; set => _price = (int)value;}
        public int QuantityProduct {get => _quantityProduct; set => _quantityProduct = value; }

    
    public Product(string productName, string productID, decimal price, int quantityProduct)
        {
            _productName = productName; 
            _productID = productID;
            _price = (int)price;
            _quantityProduct = quantityProduct;
        }

        public decimal GetTotalCost()
        {
            return Price * QuantityProduct;
        }
    }
}
