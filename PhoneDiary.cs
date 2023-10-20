using System;
namespace Phone_s_Diary
{
	public class Contact
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		
	}


    private static void ContactTable ()
    {
        var sb = new StringBuilder();
          sb.AppendFormat("{0,-2} {1,-8:} {2,-10} {3,-16}","Id","Name","Last Name", "Phone Number");
          sb.Append("\n");
          foreach (var item in Listcontact)
          {
            sb.Append(string.Format("{0,0}",item.Id));
            sb.Append(string.Format("{0,8}",item.Name));
            sb.Append(string.Format("{0,12}",item.LastName));
            sb.Append(string.Format("{0,14}",item.Phone));
            sb.Append("\n");
          } 
          System.Console.WriteLine(sb); 


    }

	
}


