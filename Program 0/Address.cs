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
    public class Address
    {        
        private string _name;           // Name
        private string _addressLine1;   // Address Line 1
        private string _addressLine2;   // Address Line 2
        private string _city;           // City
        private string _state;          // State
        private int _zip;               // Zip Code

        // Preconditions: None
        // Postconditions: The address item has been initialized with the specified values for name, address line 1,
        //                 address line 2, city, state, and zip
        public Address(string theName, string theAddressLine1, string theAddressLine2, string theCity,
            string theState, int theZip)
        {
            Name = theName;
            AddressLine1 = theAddressLine1;
            AddressLine2 = theAddressLine2;
            City = theCity;
            State = theState;
            Zip = theZip;
        }

        public string Name
        {
            // Preconditions: None
            // Postconditions: The name has been returned
            get
            {
                return _name;
            }
            // Preconditions: None
            // Postconditions: The name has been set to the specified value
            set
            {
                _name = value;
            }
        }

        public string AddressLine1
        {
            // Preconditions: None
            // Postconditions: The address line 1 has been returned
            get
            {
                return _addressLine1;
            }
            // Preconditions: None
            // Postconditions: The address line 1 has been set to the specified value
            set
            {
                _addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            // Preconditions: None
            // Postconditions: The address line 2 has been returned
            get
            {
                return _addressLine2;
            }
            // Preconditions: None
            // Postconditions: The address line 2 has been set to the specified value
            set
            {
                _addressLine2 = value;
            }
        }

        public string City
        {
            // Preconditions: None
            // Postconditions: The city has been returned
            get
            {
                return _city;
            }
            // Preconditions: None
            // Postconditions: The city has been set to the specified value
            set
            {
                _city = value;
            }
        }

        public string State
        {
            // Preconditions: None
            // Postconditions: The state has been returned
            get
            {
                return _state;
            }
            // Preconditions: None
            // Postconditions: The state has been set to the specified value
            set
            {
                _state = value;
            }
        }

        public int Zip
        {
            // Preconditions: None
            // Postconditions: The zip has been returned
            get
            {
                return _zip;
            }
            // Preconditions: None
            // Postconditions: The zip has been set to the specified value between 0 and 99999
            set
            {
                if (_zip <= 99999)
                    _zip = value;
            }
        }
        // Preconditions: None
        // Postconditions: A string is returned presenting the address data 
       
        public override string ToString()
        {
            string result;      // holds results
            
            result = string.Format("{0}{6}{1}{6}{2}{6}{3} {4:D5} {5}{6}",
                Name, AddressLine1, AddressLine2, City, State, Zip, System.Environment.NewLine);

            return result;
        }
    }
}
