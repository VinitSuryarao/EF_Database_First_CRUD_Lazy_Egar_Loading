using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Database_First
{
    class EagarLoading
    {

        static void Main(string[] args)
        {
            MDSEntities db = new MDSEntities(); // Object of context class


            foreach (tb_Client objClient in db.tb_Client.Include("tb_Address")) // use Include method with Foregin Key Table Name
            {
                Console.WriteLine("\n{0}\t{1}\t{2}", objClient.n_ClientNo, objClient.s_ClientCode, objClient.s_ClientName);

                foreach (tb_Address objAddress in objClient.tb_Address)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}\t{3}", objAddress.s_Address, objAddress.s_City, objAddress.s_Contact, objAddress.s_Email);
                }
            }
            Console.ReadLine();
        }
    }
}
