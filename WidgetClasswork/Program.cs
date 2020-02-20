using System;
using System.Collections.Generic;

namespace WidgetClasswork {
    class Program {
        static void Main(string[] args) {
            /*
            //define a collection to hold products
            var widgets = new List<IProduct>();
            //for statements to create the correct number
            for(var idx = 0; idx <3; idx++) {
                widgets.Add(new BronseWidget());
            }
            for (var idx=0; idx <7; idx++) {
                widgets.Add(new SilverWidget());
            }
            for(var idx3 = 0; idx3 < 9; idx3++) {
                widgets.Add(new GoldWidget());
            }

            var total = 0.0;
            foreach (var widget in widgets) {
                Console.WriteLine($"Widget is model {widget.GetModelName()} made in {widget.GetStateName()}");//should display the model
                total += widget.GetPrice();
            }
            Console.WriteLine($"total is {total}");
           */
            
            IProduct b1 = new BronseWidget();
            IProduct b2 = new BronseWidget();
            var mywidgets = new List<IProduct>();
            mywidgets.Add(b1);
            mywidgets.Add(b2);
            var mytotal = 0.0;
            
            //mytotal+= mywidget.GetPrice();
            
            foreach (var mywidget in mywidgets) {
                Console.WriteLine($"Widget is model {mywidget.GetModelName()}");//should display the model
                mytotal += mywidget.GetPrice();
            }
            Console.WriteLine($"total is {mytotal}");
            /*var total = b1.GetPrice();

            Console.WriteLine(total);
            IProduct s1 = new SilverWidget();
            Console.WriteLine(s1.GetPrice());
            IProduct g1 = new GoldWidget();
            Console.WriteLine(g1.GetPrice());


            //make a collection of type products
            /*my attempt
            var <List> prod = new <List> Product();
            prod.Add(b1);
            */





        }
    }
}
