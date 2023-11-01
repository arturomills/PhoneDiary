using System.Text;
using Phone_s_Diary;
internal class Program
{
    private static void Main(string[] args)
    {
        var Listcontact = new List<Contact>();

        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to SofwarTronicos Phone Directory\n");
            Console.WriteLine("Select an Option");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine("1 - Add Contact");
            Console.WriteLine("2 - View Contacts");
            Console.WriteLine("3 - Find Contact");
            Console.WriteLine("4 - Update Contact");
            Console.WriteLine("5 - Erase Contact");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter an Option");
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
                                Console.WriteLine("Insert Contact Name:");
                                newContact.Name = Console.ReadLine();
                                break;

                            case 1:
                                Console.WriteLine("Insert Contact Last Name:");
                                newContact.LastName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Insert Contact Phone Number:");
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
                                Console.WriteLine("Invalid Option, Please Select the Correct One:");
                                break;
                        }

                    }

                    Listcontact.Add(newContact);
                    Console.WriteLine("Contact Saved Successfully!\n");
                    Viewr(Listcontact, newContact.Id);
                    break;

                case "2":
                    Viewr(Listcontact);
                    break;

                case "3":

                    if (Listcontact.Count <= 0)
                    {
                        System.Console.WriteLine("No Contact Saved!");
                        break;
                    }

                    else
                    {
                        Viewr(Listcontact);
                        Console.WriteLine("Insert Id to Select");
                        var findid = Console.ReadLine();
                        var findIdCovert = Convert.ToInt32(findid);
                        var result = Listcontact.Find(x => x.Id == findIdCovert);
                        Viewr(Listcontact, findIdCovert);
                        break;
                    }

                case "4":

                    var repeat = true;

                    if (Listcontact.Count <= 0)
                    {
                        System.Console.WriteLine("No Contact Saved!");
                        break;
                    }

                    else
                    {
                        System.Console.WriteLine("List Of Contacts\n");
                        Viewr(Listcontact);
                        System.Console.WriteLine("Select an ID Contact to Update Information");
                        var idSelect = Console.ReadLine();
                        var idSelectConvert = Convert.ToInt32(idSelect);
                        var FindUpdate = Listcontact.Find(x => x.Id == idSelectConvert);
                        Viewr(Listcontact, FindUpdate.Id);

                        while (repeat == true)

                        {

                            System.Console.WriteLine("Select Field to Update\n");
                            System.Console.WriteLine(" 1 - Update Name");
                            System.Console.WriteLine(" 2 - Update Last Name");
                            System.Console.WriteLine(" 3 - Update Phone Number");
                            System.Console.WriteLine(" 4 - Exit!");
                            var UpdateOption = Console.ReadLine();

                            if (UpdateOption == "1")
                            {
                                System.Console.WriteLine("Enter New Name to Update");
                                var newName = Console.ReadLine();
                                FindUpdate.Name = newName;
                            }

                            if (UpdateOption == "2")
                            {
                                System.Console.WriteLine("Enter New Last Name to Update");
                                var newLastName = Console.ReadLine();
                                FindUpdate.LastName = newLastName;
                            }

                            if (UpdateOption == "3")
                            {
                                System.Console.WriteLine("Enter New Phone Number to Update");
                                var newPhone = Console.ReadLine();
                                FindUpdate.Phone = newPhone;
                            }

                            else if (UpdateOption == "4")
                            {
                                break;
                            }

                            else
                            {
                                System.Console.WriteLine("Select a Valid Option");
                            }

                            System.Console.WriteLine("Updated Contact !");
                            Console.WriteLine(FindUpdate.Id + " " + FindUpdate.Name + " " + FindUpdate.LastName + " " + FindUpdate.Phone);
                        }
                    }

                    break;

                case "5":

                    if (Listcontact.Count <= 0)
                    {
                        System.Console.WriteLine("No Contact Saved!");
                        break;
                    }

                    else
                    {
                        System.Console.WriteLine("List Of Contacts\n");
                        Viewr(Listcontact);
                        System.Console.WriteLine("Select an ID Contact to Erase");
                        var EraseId = Console.ReadLine();
                        var EraseIdConvert = Convert.ToInt32(EraseId);
                        var EraseFind = Listcontact.Find(x => x.Id == EraseIdConvert);
                        Viewr(Listcontact, EraseFind.Id);
                        Listcontact.Remove(EraseFind);
                        Console.WriteLine("Contact Successfully Deleted!");

                    }
                    break;

                case "6":
                    Console.WriteLine("Thanks For Using This Directory, Good Bye!!");
                    return;

                default:
                    Console.WriteLine("Enter a Valid Option!");
                    break;

            }
        }
    }

    private static void Viewr(List<Contact> listToFormat, int idfind = 0)
    {
        var sb = new StringBuilder();
        var sbl = new StringBuilder();

        if (listToFormat.Count <= 0)
        {
            System.Console.WriteLine("No Contacts Saved!!");
        }

        else
        {

            sb.Append(string.Format("{0,-5}", "Id"));
            sb.Append(string.Format("{0,-10}", "Name"));
            sb.Append(string.Format("{0,-14}", "Last Name"));
            sb.Append(string.Format("{0,-14}", "Phone Number"));
            sb.Append("\n");

            foreach (var item in listToFormat)

            {
                sb.Append(string.Format("{0,-5}", item.Id));
                sb.Append(string.Format("{0,-10}", item.Name));
                sb.Append(string.Format("{0,-14}", item.LastName));
                sb.Append(string.Format("{0,-14}", item.Phone));
                sb.Append("\n");

            }

            if (idfind == 0)
            {
                Console.WriteLine(sb);
            }
            else
            {
                sbl.Append(string.Format("{0,-5}", "Id"));
                sbl.Append(string.Format("{0,-10}", "Name"));
                sbl.Append(string.Format("{0,-14}", "Last Name"));
                sbl.Append(string.Format("{0,-14}", "Phone Number"));
                sbl.Append("\n");

                foreach (var item in listToFormat)
                {
                    if (item.Id == idfind)
                    {
                        sbl.Append(string.Format("{0,-5}", item.Id));
                        sbl.Append(string.Format("{0,-10}", item.Name));
                        sbl.Append(string.Format("{0,-14}", item.LastName));
                        sbl.Append(string.Format("{0,-14}", item.Phone));
                        sbl.Append("\n");
                        System.Console.WriteLine(sbl);
                    }
                }
            }
        }
    }
}