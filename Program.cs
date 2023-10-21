using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Phone_s_Diary;

internal class Program
{
    private static void Main(string[] args)
    {
        var Listcontact = new List<Contact>();

        while (true)
        {
            Console.WriteLine("\n");
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
                                Console.WriteLine("Invalid Option:");
                                break;
                        }

                    }

                    Listcontact.Add(newContact);
                    Console.WriteLine("Contact Saved!\n");
                    Console.WriteLine(newContact.Name + " " + newContact.LastName + " - " + newContact.Phone);

                    break;

                case "2":
                    viewr(Listcontact);
                    break;

                case "3":

                    if (Listcontact.Count <= 0)
                    {
                        System.Console.WriteLine("No Contact Saved!");
                        break;
                    }
                    else
                    {
                        viewr(Listcontact);
                        var LookName = Console.ReadLine();
                        var LookNameCovert = Convert.ToInt32(LookName);
                        System.Console.WriteLine("Inser Id to Select");
                        var FindName = Listcontact.Find(x => x.Id == LookNameCovert);
                        Console.WriteLine(FindName.Id + " " + FindName.Name + " " + FindName.LastName + " " + FindName.Phone);
                        break;
                    }




                case "4":

                    if (Listcontact.Count <= 0)
                    {
                        System.Console.WriteLine("No Contact Saved!");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("List Of Contacts\n");
                        viewr(Listcontact);
                        System.Console.WriteLine("Select an ID Contact to Update");
                        var idSelect = Console.ReadLine();
                        var idSelectConvert = Convert.ToInt32(idSelect);
                        var FindUpdate = Listcontact.Find(x => x.Id == idSelectConvert);
                        Console.WriteLine(FindUpdate.Id + " " + FindUpdate.Name + " " + FindUpdate.LastName + " " + FindUpdate.Phone);
                        System.Console.WriteLine("Select a Field to Update\n");
                        System.Console.WriteLine(" 1 - Update Name");
                        System.Console.WriteLine(" 2 - Update Last Name");
                        System.Console.WriteLine(" 3 - Update Phone Number");
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

                        else
                        {
                            System.Console.WriteLine("Select a Valid Option");
                        }
                        System.Console.WriteLine("Updated Contact !");
                        Console.WriteLine(FindUpdate.Id + " " + FindUpdate.Name + " " + FindUpdate.LastName + " " + FindUpdate.Phone);
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
                        viewr(Listcontact);
                        System.Console.WriteLine("Select an ID Contact to Erase");
                        //var idSelectErase = Console.ReadLine();
                        var EraseId = Console.ReadLine();
                        var EraseIdConvert = Convert.ToInt32(EraseId);
                        var EraseFind = Listcontact.Find(x => x.Id == EraseIdConvert);
                        Console.WriteLine(EraseFind.Id + " " + EraseFind.Name + " " + EraseFind.LastName + " " + EraseFind.Phone);
                        Listcontact.Remove(EraseFind);
                        Console.WriteLine("Erased Contact!");
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
                    }



                    break;

                case "6":
                    Console.WriteLine("Thanks For Using This Dairy, Good Bye!!");
                    return;


                default:
                    {

                        Console.WriteLine("Enter a Valid Option!");
                    }
                    break;




            }


        }


    }

    private static void viewr(List<Contact> listToFormat)
    {
        if (listToFormat.Count <= 0)
        {
            System.Console.WriteLine("No Contacts Saved!!");

        }

        else
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0,-2} {1,-8:} {2,-10} {3,-16}", "Id", "Name", "Last Name", "Phone Number");
            sb.Append("\n");
            foreach (var item in listToFormat)
            {
                sb.Append(string.Format("{0,0}", item.Id));
                sb.Append(string.Format("{0,8}", item.Name));
                sb.Append(string.Format("{0,12}", item.LastName));
                sb.Append(string.Format("{0,14}", item.Phone));
                sb.Append("\n");
            }
            Console.WriteLine(sb);

        }
    }

}

