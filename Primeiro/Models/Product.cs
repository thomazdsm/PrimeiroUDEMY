using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Primeiro.Models
{
    class Product
    {
        //ATRIBUTES
        private string _name;
        public double Price { get; set; }
        public int Amount { get; private set; }

        //CONSTRUCTOR
        public Product()
        {
        }
        public Product(string name, double price, int amount)
        {
            _name = name;
            Price = price;
            Amount = amount;
        }

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { 
                if(value != null && value.Length > 1)
                {
                    _name = value;
                }    
            }
        }

        /*GET & SET METHOD
        public double GetPrice()
        {
            return _price;
        }
        public void SetPrice(double price)
        {
            _price = price;
        }
        public int GetAmount()
        {
            return _amount;
        }
        */

        //METHODS
        public double TotalStockValue()
        {
            return Amount * Price;
        }

        public void AddProduct(int quantity)
        {
            Amount = Amount + quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Amount = Amount - quantity;
        }

        public override string ToString()
        {
            return _name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Amount + " unidades. Total: $" + TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
