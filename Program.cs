using Phone_s_Diary;

var Listcontact = new List<Contact>();
var listaPrueba = new Contact

{
    Id = 1,
    Name = "Jhon",
    LastName = "Doe",
    Phone = "800-220-0000"

};

Listcontact.Add(listaPrueba);

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

            var NewList = new Contact
            {
                Id = Listcontact.Count() + 1,
                Name = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Phone = Console.ReadLine(),
            };

            Listcontact.Add(NewList);
            System.Console.WriteLine("Contact Saved!\n");
            System.Console.WriteLine(NewList.Name + " " + NewList.LastName + " - " + NewList.Phone);

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
            System.Console.WriteLine("Erased Contact!");
            System.Console.WriteLine(EraseFind.Id + " " + EraseFind.Name + " " + EraseFind.LastName + " " + EraseFind.Phone);
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



