using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class InternationalShipment : Shipment
    {
        private string destinationcountry;
        private decimal customsfee;


        public string DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    destinationcountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsfee; }
            set
            {
                if (value >= 0)
                    customsfee = value;
            }
        }
        public InternationalShipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationcountry, decimal extrafee) : base(trackingcode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = extrafee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Description         : {Description}");
            Console.WriteLine($"Weight              : {Weight}");
            Console.WriteLine($"Delivery Fee        : {DeliveryFee}");
            Console.WriteLine($"Destination         : {Destination.GetFullAddress()}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {TrackingCode}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }

    }
}
