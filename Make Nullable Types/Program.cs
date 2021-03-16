using System;

namespace Make_Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? areYouMaster = null;

            if(areYouMaster == true)
            {
                Console.WriteLine("You are master.");
            }
            else if(areYouMaster == false)
            {
                Console.WriteLine("You are not master.");
            }
            else
            {
                Console.WriteLine("You did not answer the question.");
            }

            int? ticketOnSale = null;
            int availableTickets;

            if(ticketOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = (int)ticketOnSale;
            }
            Console.WriteLine("Available tickets " + availableTickets);
        }
    }
}
