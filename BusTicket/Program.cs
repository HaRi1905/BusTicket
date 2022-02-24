//Inheritance Exercise

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket
{  
class Bus
    {
        public string Travels_name;
        public int fare;
        public string customer_name;
        public string Boarding_pt;
        
    }
class Srm_Travels : Bus
    {
        
        public void ticketbook(string customer, string board)
        {
            customer_name=customer;
            Boarding_pt=board;
        }

    }

    class Kpn_Travels: Bus
    {
        public void ticketbook(string customer, string board)
        {
            customer_name = customer;
            Boarding_pt = board;
        }

    }
    class Program
    {
        static void Main(string[] args)

        {
            Srm_Travels srm=new Srm_Travels();
            srm.Travels_name = "SRM Travels";
            srm.ticketbook("Hari","Chengalpatu");
            srm.fare = 1000;
            Console.WriteLine("Travels name is " + srm.Travels_name);
            Console.WriteLine("Customer Name is "+  srm.customer_name);
            Console.WriteLine("Boarding point is "+ srm.Boarding_pt);
            Console.WriteLine(srm.fare);
            Kpn_Travels kpn=new Kpn_Travels();
            kpn.Travels_name = "KPN Travels";
            kpn.ticketbook("Rajkumar", "Vilupuram");
            kpn.fare = 750;
            Console.WriteLine("Travels name is "+ kpn.Travels_name);
            Console.WriteLine("Customer Name is "+ kpn.customer_name);
            Console.WriteLine("Boarding point is "+ kpn.Boarding_pt);
            Console.WriteLine(kpn.fare);

            Console.ReadKey();
        }
    }
}
