namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Question01
            //Q1  Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            /*
             Method Overloading Allow the class to have multible Methods with the same name but with different parameters (One Method with multible tasks)
             Method Overriding the method is already exists in the base class (Parent) but with different implementation in the derived class (Child) (same Method with different implementation)
             */

            //b)  What is the difference between Static Binding and Dynamic Binding?
            /*
             Static Binding is a technique that happens in the compile time by compiler , Faster than Dynamic Binding , Referance always wins , (Method overloading , static methods , method hiding)
             Dynamic Binding is a technique that happens in run time by CLR , Slower than Static Binding , The object wins , (Method Overriding, Abstract Methods) )
             */
            #endregion

            #region Question02
            //Q2  Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            /*
             Sealed keyword when applied to a class makes the class can not be inherited we use it mainly to protect senstive data (there is no inheritance chain)
             */
            //b)  What is the difference between a sealed class and a sealed method? 
            /*
             sealed class can not be inherited at all , sealed method prevent the further override of a specific method 
             */
            //c)  Can a sealed method be overridden? Why?
            /*
             No , A Sealed Method can't be overridden After using sealed keyword because it means that this method override is final and can not be overridden further 
             */
            #endregion

            #endregion
            #region Part 02 — Practical

            Driver driver = new Driver(1,"Ahmed Shaker","01117248622");

            DeliveryCenter center = new DeliveryCenter();

            center.Driver = driver;


            StandardShipment standard = new StandardShipment("SH001","Laptop",3,80,new DeliveryAddress("Cairo", "Tahrir", 10));


            ExpressShipment express = new ExpressShipment("SH002","Phone",2,60,new DeliveryAddress("Cairo", "Nasr St", 1),30);


            InternationalShipment international =new InternationalShipment("SH003","Television",8,120,new DeliveryAddress("Cairo", "Nile St", 18),"Germany",100);

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            Console.WriteLine();

            Console.WriteLine($"Driver : {center.Driver.FullName}");

            Console.WriteLine();

            center.PrintAllShipments();


            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine("==========================================");

            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);


            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight...");
            Console.WriteLine();

            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("==========================================");

            Shipment[] mixedShipments ={standard,express,international};

            foreach (Shipment shipment in mixedShipments)
            {
                shipment.PrintShipment();
            }


            Console.WriteLine("==========================================");

            // Sealed Class demonstration
            CompletedShipment completed =new CompletedShipment("SH004","Documents",1,50,new DeliveryAddress("Cairo", "Tahrir Street", 5));

            // Sealed Method demonstration
            PriorityInternationalShipment priority =new PriorityInternationalShipment("SH005","Passport",1,100,new DeliveryAddress("Cairo", "Airport Road", 15),"Germany",50);

            priority.GenerateCustomsReport();

            #endregion
        }
    }
}
