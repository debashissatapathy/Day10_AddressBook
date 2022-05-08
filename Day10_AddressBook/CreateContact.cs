using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_AddressBook
{
    class CreateContact
    {
        List<ContactPerson> People = new List<ContactPerson>();
        Dictionary<string, List<ContactPerson>> dict = new Dictionary<string, List<ContactPerson>>();
        public void contacts()
        {
            ContactPerson contact = new ContactPerson();
            Console.WriteLine("Enter person contact detail\n");
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter Zip : ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("\n");
            People.Add(contact);
            Console.WriteLine("Contact Saved.");
            Console.WriteLine("\n");
        }
        public void EditContact()
        {
            Console.WriteLine("Enter person name for edit");            
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("Choose one option for edit detail\n 1.FirstName\n2.LastName\n3.PhoneNumber\n4.Email\n5.Address\n6.City\n7.State\n8.Zip");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter firstname for edit contact");
                            string firstName = Console.ReadLine();
                            data.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Lastname for edit contact");
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter phone number for edit contact");
                            string phoneNumber = Console.ReadLine();
                            data.PhoneNumber = phoneNumber;
                            break;
                        case 4:
                            Console.WriteLine("Enter email for edit contact");
                            string email = Console.ReadLine();
                            data.Email = email;
                            break;
                        case 5:
                            Console.WriteLine("Enter Address for edit contact");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 6:
                            Console.WriteLine("Enter City for edit contact");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 7:
                            Console.WriteLine("Enter state for edit contact");
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 8:
                            Console.WriteLine("Enter Zipcode for edit contact");
                            string ZipCode = Console.ReadLine();
                            data.Zip  = ZipCode;
                            break;
                        default:
                            Console.WriteLine("Given input {0} is inccorrect, Try agian.", name);
                            break;
                    }                    
                }
                else if(data.FirstName == null)
                {
                    Console.WriteLine("Given input {0} is not available in Address Book. Please ty again.", name);
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the person for delete");
            string name = Console.ReadLine();
            foreach(var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            People.Remove(data);
                            Console.WriteLine("\nContact deleted successfully");
                            return;
                        }
                        
                        
                    }
                }
            }
            Console.WriteLine("Given name contact doesn't exist in Addressbook");

        }
        public void AddUniqueContact()
        {
            Console.WriteLine("Enter the Firstname in your contatlist");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("This contact exists.\nPlease enter an unique name to store this data: ");
                    string UniqueName = Console.ReadLine();
                    if (dict.ContainsKey(UniqueName))
                    {
                        Console.WriteLine("This unique name already exist");
                    }
                    else
                        dict.Add(UniqueName, People);
                    Console.WriteLine("\nUnique Name saved.");
                    return;
                }
            }
            Console.WriteLine("This contact list doesn't exist, please create a contactlist.");
            return;
        }
        public void DisplayUniqueContact()
        {
            Console.WriteLine("Enter the uniqueName of your contact");
            string name = Console.ReadLine();

            foreach(var data in dict)
            {
                if (data.Key.Contains(name))
                {
                    foreach (var contact in data.Value)
                    {
                        Console.WriteLine("The details of  " + name + " are\n" + "Name: " +contact.FirstName +"\nMob: "+ contact.PhoneNumber);
                        
                        return;
                    }
                }
                else
                    Console.WriteLine("This uniquename doesn't exist");
            }
            Console.WriteLine("The Unique list doesn't exist, please create a uniquelist.");
        }
       
        public void PersonDetail()
        {
            Console.WriteLine("Enter FirstName for gettinf details: ");
            string name = Console.ReadLine();
            foreach(var data in People)
            {
                if(data.FirstName == name)
                {
                    Console.WriteLine("Name of person: {0} {1}", data.FirstName, data.LastName);
                    Console.WriteLine("Email Id: {0}", data.Email);
                    Console.WriteLine("ontact Number: {0}", data.PhoneNumber);
                    Console.WriteLine("Address: At: {0}  city: {1}  State: {2} Zip: {3}", data.Address, data.City, data.State, data.Zip);
                }
                
            }
        }

    }
}
