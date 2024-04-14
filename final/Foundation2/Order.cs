using System;
namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        
        public Order(List<Product> products,Customer customer)
        {
        _products = products;
        _customer = customer;
        }
        public decimal CaluculateTotalCost()
        {
           decimal totalCost = _products.Sum(p => p.GetTotalCost());
            if(_customer.USA())
                totalCost += 5;
            else
                totalCost += 35;
            return totalCost;
        }
        public string GetPackLabel()
        {
            
            string packLabel = "=== Packing Label ===\n";
            packLabel += $"Customer Name: {_customer.customerName}\n\n";

            packLabel += "Products:\n";
            foreach (var products in _products) 
            {  
                packLabel += $"Product ID: {products.ProductID}\n";
                packLabel += $"Product Name: {products.Productname}\n";
                packLabel += $"Product Quantity:{products.QuantityProduct}\n";
            }
            packLabel += $"Total Cost: {CaluculateTotalCost():c}\n";
            return packLabel;
        }
        public string GetShipLabel ()
        {
            return $"Customer Name: {_customer.customerName}\n{_customer.Address}\n{_customer.Address.GetCompleteAddress()}";
        }
      
    } 
}   

   
        
        
        
     