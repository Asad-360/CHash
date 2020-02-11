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
            customEventHandler.CustomEventHandler += CustomEventHandler_CustomEventHandler;
            customEventHandler.InvokeDefaultEventHandler();
            customEventHandler.InvokeEvent("Custom arguments");
        }

        private static void CustomEventHandler_CustomEventHandler(object sender, EventArgs e)
        {
            var args = e as CustomEventArgs;
            Console.WriteLine("Custom Event Handler Using Event Handler Delegate Is Raised: "+args.Name.ToUpper().ToString());
        }

        private static void SampleEventHandler(string args)
        {
            Console.WriteLine("Event is Raised with args:"+args);
            Console.ReadLine();
        }
    }
}
