using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class DeliveryCenter
    {
        public Driver Driver { get; set; }
        private string centerName;
        public string CenterName
        {
            get
            {
                return centerName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
            }
        }
        private Shipment[] shipments = new Shipment[20];
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null &&
                        shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    s.PrintShipment();
                    Console.WriteLine("-----------------------");
                }
            }
        }

    }
}
