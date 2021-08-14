using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            MDSEntities db = new MDSEntities(); // Object of context class
            tb_Client clientobj = new tb_Client(); // Object of Entity Class
            int Option;

            do
            {
                Console.WriteLine("1:Read  2:Add  3:Update  4:Delete");
                Console.WriteLine("Enter Option");
                Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:// Read All Records
                        foreach (tb_Client item in db.tb_Client)
                        {
                            Console.WriteLine("\n{0}\t{1}\t{2}", item.n_ClientNo, item.s_ClientCode, item.s_ClientName);
                        }
                        break;

                    case 2: // Add Record
                        Console.WriteLine("Enter Client Code and Client Name");
                        clientobj.s_ClientCode = Console.ReadLine();
                        clientobj.s_ClientName = Console.ReadLine();

                        db.tb_Client.Add(clientobj);// Add Entity Class to Context
                        db.SaveChanges(); // Call context class method to save
                        Console.WriteLine("Records Added Successfully !");
                        break;

                    case 3: // Update Record
                        Console.WriteLine("Enter Client No For Update");
                        int id = Convert.ToInt32(Console.ReadLine());
                        clientobj = db.tb_Client.Find(id);
                        if (clientobj == null)
                            Console.WriteLine("Invalid Client Number");
                        else
                        {
                            Console.WriteLine("Enter Client Name For Upate");
                            clientobj.s_ClientName = Console.ReadLine(); // Update Client Name in entity Clas
                            db.SaveChanges();// use context class to save
                        }
                        Console.WriteLine("Records Updated Successfully !");
                        break;

                    case 4: // Delete Record
                        Console.WriteLine("Enter Client No For Delete");
                        int no = Convert.ToInt32(Console.ReadLine());
                        clientobj = db.tb_Client.Find(no);
                        if (clientobj == null)
                            Console.WriteLine("Invalid Client Number");
                        else
                        {
                            db.tb_Client.Remove(clientobj);
                            db.SaveChanges();// use context class to save
                        }
                        Console.WriteLine("Records Deleted Successfully !");
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            } while (Option != 5);
        }
    }
}
