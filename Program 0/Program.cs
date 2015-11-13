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
    class Program
    {
        static void Main(string[] args)
        {
            List<Parcel> parcels = new List<Parcel>();      // List of parcels
            List<Address> addresses = new List<Address>();  // List of addresses

            addresses.Add(new Address(" John Smith", "1234 Main st", "apt 1", "New York", "NY", 12345));
            addresses.Add(new Address("Jane Doe", "1000 elm st", "apt 2", "Louisville", "KY", 40208));
            addresses.Add(new Address("George Washington", "9876 Market st", "Building 1A", "Washington", "DC", 98765));
            addresses.Add(new Address("Luke Skywalker", "101 desert rd", "building 2", "Mos Eisly", "Tatooine", 42320));

            parcels.Add(new Letter(addresses[0], addresses[1], 1));
            parcels.Add(new Letter(addresses[1], addresses[2], 2));
            parcels.Add(new Letter(addresses[2], addresses[3], 3));

            foreach (Letter letter in parcels)
                Console.WriteLine("{0}\n", letter);
        }
    }
}
