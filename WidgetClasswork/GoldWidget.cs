using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork {
    class GoldWidget : IProduct {

        public Product Product { get; set; }

        public double GetPrice() {
            //Console.WriteLine("Silver");
            return Product.GetPrice();
        }

        public GoldWidget() {
            Product = new Product {//creating the instance and initialize it
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold//only thing needed
            };
        }
        public string GetModelName() {
            return Product.GetModelName();
        }
        public string GetStateName() {
            return Product.GetStateName();
        }
    }
}
