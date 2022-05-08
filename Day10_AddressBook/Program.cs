using System;

namespace Day10_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            CreateContact create = new CreateContact();
            while (true)
            {
                Console.WriteLine("Choose one Action to do: \n1.Add Contact\n2.Edit Contact\n3.Person Detail\n4.Delete Contact\n5.AddUniqueContat\n6.DisplayUniqueContact");
                
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        create.contacts();
                        break;
                    case 2:
                        create.EditContact();
                        break;
                    case 3:
                        create.PersonDetail();
                        break;
                    case 4:
                        create.DeleteContact();
                        break;
                    case 5:
                        create.AddUniqueContact();
                        break;
                    case 6:
                        create.DisplayUniqueContact();
                        break;
                    default:
                        Console.WriteLine("Given numbee ris inorrect, please with correct one.\n");
                        break;
                }

            }


        }
    }
}
