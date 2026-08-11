using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode,string description, decimal weight, decimal deliveryFee,DeliveryAddress destination,string destinationCountry,decimal customsFee): base(trackingCode,description,weight,deliveryFee,destination,destinationCountry,customsFee)
        {

        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for {TrackingCode}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }
    }
}
