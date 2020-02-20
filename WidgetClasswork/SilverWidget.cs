using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork {
    class SilverWidget : IProduct{

        public Product Product { get; set; }

        public double GetPrice() {
            //Console.WriteLine("Silver");
            return Product.GetPrice();
        }

        public SilverWidget() {//constructor
            Product = new Product {//creating the instance and initialize it
                Code = "SW",
                Name = "Silver Widget",
                Model = ModelType.Silver//only thing needed
            };
        }
        public string GetModelName() {//method
            return Product.GetModelName();
        }
        public string GetStateName() {
            return Product.GetStateName();
        }
    }
}
