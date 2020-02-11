using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsHandler customEventHandler = new EventsHandler();
            customEventHandler.SimpleEvent += SampleEventHandler;
            
            customEventHandler.InvokeEvent("Custom arguments");
        }

       

        private static void SampleEventHandler(string args)
        {
            Console.WriteLine("Event is Raised with args:"+args);
            Console.ReadLine();
        }
    }
}
