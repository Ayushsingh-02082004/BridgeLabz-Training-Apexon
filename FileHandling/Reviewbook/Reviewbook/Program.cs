// See https://aka.ms/new-console-template
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Reviewbook;


public class Program
{
    public static Dictionary<char, List<Contacts>> addressBook = new Dictionary<char, List<Contacts>>();

    public static bool AddContact(Contacts contact)
    {
        char key = char.ToUpper(contact.FirstName[0]);

        if (!addressBook.ContainsKey(key))
        {
            addressBook[key] = new List<Contacts>();
        }

        addressBook[key].Add(contact);
        return true;
    }

    public static IEnumerable<IGrouping<string, Contacts>>GetGroupedAndSortedContacts(char key)
    {
        if (!addressBook.ContainsKey(key))
            return Enumerable.Empty<IGrouping<string, Contacts>>();

        return addressBook[key]
            .OrderBy(c => c.FirstName)   
            .GroupBy(c => c.City)        
            .OrderBy(g => g.Key);        
    }

    public static void DisplayAddressBook()
    {
        foreach (var entry in addressBook.OrderBy(e => e.Key)) 
        {
            Console.WriteLine($"{entry.Key}:");

            var groupedContacts = GetGroupedAndSortedContacts(entry.Key);

            foreach (var cityGroup in groupedContacts)
            {
                Console.WriteLine($"  City: {cityGroup.Key}");

                foreach (var contact in cityGroup)
                {
                    Console.WriteLine(
                        $"    {contact.FirstName} {contact.LastName}, {contact.City}"
                    );
                }
            }

            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        List<Contacts> contactsdata = new List<Contacts>
        {
            new Contacts("Ayush", "Singh", "MG Road", "Bangalore", "Karnataka", "560001"),
            new Contacts("Ankit", "Verma", "Civil Lines", "Bangalore", "Delhi", "110001"),
            new Contacts("Aman", "Gupta", "Park Street", "Bangalore", "West Bengal", "700016"),
            new Contacts("Alok", "Mishra", "Alambagh", "Bangalore", "Uttar Pradesh", "226005"),
            new Contacts("Arjun", "Mehta", "Ring Road", "Ahmedabad", "Gujarat", "380001"),

            new Contacts("Rohit", "Sharma", "Link Road", "Mumbai", "Maharashtra", "400001"),
            new Contacts("Ravi", "Patel", "CG Road", "Vadodara", "Gujarat", "390001"),
            new Contacts("Rahul", "Khanna", "South Ex", "Delhi", "Delhi", "110049"),
            new Contacts("Rakesh", "Yadav", "Station Road", "Gorakhpur", "Uttar Pradesh", "273001"),
            new Contacts("Ritu", "Malhotra", "Sector 15", "Chandigarh", "Chandigarh", "160015"),

            new Contacts("Priya", "Mehta", "Ring Road", "Ahmedabad", "Gujarat", "380015"),
            new Contacts("Pooja", "Iyer", "T Nagar", "Chennai", "Tamil Nadu", "600017"),
            new Contacts("Prakash", "Joshi", "Paltan Bazaar", "Dehradun", "Uttarakhand", "248001"),
            new Contacts("Pankaj", "Bansal", "Model Town", "Ludhiana", "Punjab", "141001"),
            new Contacts("Preeti", "Arora", "Sector 22", "Gurgaon", "Haryana", "122015"),

            new Contacts("Neha", "Kapoor", "Model Town", "Ludhiana", "Punjab", "141002"),
            new Contacts("Nikhil", "Bansal", "Rajouri Garden", "Delhi", "Delhi", "110027"),
            new Contacts("Nitin", "Agarwal", "Civil Lines", "Aligarh", "Uttar Pradesh", "202001"),
            new Contacts("Nisha", "Verma", "GT Road", "Kanpur", "Uttar Pradesh", "208001"),
            new Contacts("Naveen", "Kumar", "Ashok Nagar", "Chennai", "Tamil Nadu", "600083"),

            new Contacts("Suresh", "Reddy", "Banjara Hills", "Hyderabad", "Telangana", "500034"),
            new Contacts("Sunita", "Kumari", "Kankarbagh", "Patna", "Bihar", "800020"),
            new Contacts("Sanjay", "Srivastava", "Gomti Nagar", "Lucknow", "Uttar Pradesh", "226010"),
            new Contacts("Sneha", "Nair", "Vyttila", "Kochi", "Kerala", "682019"),
            new Contacts("Shubham", "Jain", "Clock Tower", "Jaipur", "Rajasthan", "302001")
        };

        foreach (var contact in contactsdata)
        {
            AddContact(contact);
        }

        DisplayAddressBook();
    } 

}
