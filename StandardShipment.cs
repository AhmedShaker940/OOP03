using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class StandardShipment :Shipment
    {

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        public StandardShipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingcode, description, weight, deliveryFee, destination)
        {

        }

    }
}
