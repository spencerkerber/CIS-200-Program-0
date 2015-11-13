// Spencer Kerber
// CIS 200-10
// Program 0
// Parcel Service
// Due 5/21/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel
    {
        public Address _originAddress;          // Origin address
        public Address _destinationAddress;     // Destination address

        // Preconditions: None
        // Postconditions: The parcel item is initialized with the specified values for origin address and destiation address
        public Parcel(Address theOriginAddress, Address theDestinationAddress)
        {
            OriginAddress = theOriginAddress;
            DestinationAddress = theDestinationAddress;

            CalcCost();
        }
        public Address OriginAddress
        {
            // Preconditions: None
            // Postconditions: Origin address is returned
            get
            {
                return _originAddress;
            }
            // Preconditions: None
            // Postconditions: Origin address is set to the specified value
            set
            {
                _originAddress = value;
            }
        }

        public Address DestinationAddress
        {
            // Preconditions: None
            // Postconditions: Destination address is returned
            get
            {
                return _destinationAddress;
            }
            // Preconditions: None
            // Postconditions: Destination address is set to the specified value
            set
            {
                _destinationAddress = value;
            }
        }

        // Preconditions: None
        // Postconditions: The cost for the item is calculated 
        public abstract decimal CalcCost();

        // Preconditions: None
        // Postconditions: A string is returned presenting the parel information on separate lines
        public override string ToString()
        {
            string result;      // holds results

            result = string.Format("Origin Address: {3}{0}{3}Destination Address: {3}{1}{3}Cost: {2:C}{3}",
                OriginAddress, DestinationAddress, CalcCost(), System.Environment.NewLine);

            return result;
        }
    }
}
