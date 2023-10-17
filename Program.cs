using Phone_s_Diary;

var Listcontact = new List<Contact>();

while (true)
{
    System.Console.WriteLine("\n");
    Console.WriteLine("Welcome to SofwarTronicos Phone Diary\n");
    Console.WriteLine("Select an Option");
    Console.WriteLine("-----------------------------\n");
    Console.WriteLine("1 - Add Contact");
    Console.WriteLine("2 - View Contacts");
    Console.WriteLine("3 - Find Contact");
    Console.WriteLine("4 - Update Contact");
    Console.WriteLine("5 - Erase Contact");
    Console.WriteLine("6 - Exit");
    Console.WriteLine("");
    Console.WriteLine("Enter Option");
    var Options = Console.ReadLine();



    switch (Options)
    {

        case "1":

            var newContact = new Contact();

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        System.Console.WriteLine("Insert Contact Name:");
                        newContact.Name = Console.ReadLine();
                        break;

                    case 1:
                        System.Console.WriteLine("Insert Contact Last Name:");
                        newContact.LastName = Console.ReadLine();
                        break;

                    case 2:
                        System.Console.WriteLine("Insert Contact Phone Number:");
                        newContact.Phone = Console.ReadLine();
                        break;

                    case 3:
                        if (Listcontact.Count > 0)
                        {
                        newContact.Id = Listcontact.Max(x => x.Id) + 1;
                        }
                        
                        else
                        {
                            newContact.Id = 1;
                        }
                        break;
                    default:
                        System.Console.WriteLine("Invalid Option:");
                        break;
                }

            }

            Listcontact.Add(newContact);
            System.Console.WriteLine("Contact Saved!\n");
            System.Console.WriteLine(newContact.Name + " " + newContact.LastName + " - " + newContact.Phone);

            break;

        case "2":
            foreach (var Item in Listcontact)
            {
                Console.WriteLine(Item.Id + " - " + Item.Name + " " + Item.LastName + " - " + Item.Phone);
                System.Console.WriteLine("-----------------------------------");

            }

            break;
        case "3":

            var LookName = Console.ReadLine();

            var FindName = Listcontact.Find(x => x.Name.ToLower() == LookName.ToLower());

            System.Console.WriteLine(FindName.Id + " " + FindName.Name + " " + FindName.LastName + " " + FindName.Phone);
            break;

        case "4":
            var UpdateNumber = Console.ReadLine();
            var FindUpdate = Listcontact.Find(x => x.Name.ToLower() == UpdateNumber.ToLower());
            Console.WriteLine("New Nomber to Save");
            var NewNumber = Console.ReadLine();
            FindUpdate.Phone = NewNumber;
            System.Console.WriteLine("New Nomber Saved Correctly");
            System.Console.WriteLine(FindUpdate.Id + " " + FindUpdate.Name + " " + FindUpdate.LastName + " " + FindUpdate.Phone);
            break;


        case "5":
            var EraseName = Console.ReadLine();
            var EraseFind = Listcontact.Find(x => x.Name.ToLower() == EraseName.ToLower());
            Listcontact.Remove(EraseFind);
            System.Console.WriteLine("Erased Contact!");
            System.Console.WriteLine(EraseFind.Id + " " + EraseFind.Name + " " + EraseFind.LastName + " " + EraseFind.Phone);
            foreach (var item in Listcontact)
            {
                if (item.Id > EraseFind.Id)
                {
                    item.Id -= 1;
                }

                else
                {
                    item.Id = item.Id;
                }
                
            }
            break;

        case "6":
            System.Console.WriteLine("Thanks For Using This Dairy, Good Bye!!");
            return;


        default:
            {

                System.Console.WriteLine("Enter a Valid Option!");
            }
            break;




    }

}



