using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork {
    class BronseWidget : IProduct {

        //public Product bw { get; set; }
        public Product Product { get; set; }//defines the class doesn't create an instance

        public double GetPrice() {
            //Console.WriteLine("Bronse");
            //bw.Model
            //return bw.GetPrice();

            // return 20;
            return Product.GetPrice();
        }

        public string GetModelName() {
            return Product.GetModelName();
        }

        public string GetStateName() {
            return Product.GetStateName();
        }


        public BronseWidget() {
            Product = new Product {//creating the instance and initialize it
                Code = "BW",
                Name = "Bronse Widget",
                Model = ModelType.Bronse//only thing needed
            };
        }

        
    }
}
