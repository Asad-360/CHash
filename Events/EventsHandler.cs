using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EventsHandler
    {
        // Steps for creating events 
        // 1. Create simple delegate
        // 2. Create event using delegate
        // 3. Invoke event
        // 4. Attach Handler
        public delegate void SimpleDelegate(string args);
        public SimpleDelegate SimpleEvent;
        public void InvokeEvent(string customArgs)
        {
            SimpleEvent(customArgs);
        }
    }
}
