using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace OOPS
{
    //idhil multiple iterfaces impliment cheyyanum pattum
    // Interface definition
    interface IChatSystem
    {
        void SendMessage();
        void ReceiveMessage();
    }

    // Class implementing the interface
    class Whatsapp : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message via WhatsApp");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving message via WhatsApp");
        }
    }

    // Another class implementing the interface
    class Telegram : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message via Telegram");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving message via Telegram");
        }
    }



    
}