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
    class Letter: Parcel
    {
        private decimal _fixedCosts;

        // Preconditions: None
        // Postconditions: The letter item has been initialized with the spcified values for origin address, destination 
        //                 address, and fixed costs
        public Letter(Address theOriginAddress, Address theDestinationAddress, decimal theFixedCosts)
            :base(theOriginAddress, theDestinationAddress)
        {
            fixedCosts = theFixedCosts;
        }

        public decimal fixedCosts
        {
            // Preconditions: None
            // Postconditions: fixed costs is returned
            get
            {
                return _fixedCosts;
            }
            // Preconditions: None
            // Postconditions: Fixed costs is set to the specified value
            set
            {
                _fixedCosts = value;
            }
        }

        // Preconditions: None
        // Postconditions: CalcCost is set to Fixed costs
        public override decimal CalcCost()
        {
            return fixedCosts;
        }

        // Preconditions: None
        // Postconditions: A string is returned presenting the letter information
        public override string ToString()
        {
            string result;      // holds results

            result = string.Format("Origin Address: {3}{0}{3}Destination Address: {3}{1}{3}Costs: {2:C}{3}",
                OriginAddress, DestinationAddress, fixedCosts, System.Environment.NewLine);

            return result;
        }       
    }
}
