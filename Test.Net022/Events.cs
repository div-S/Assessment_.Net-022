using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net022
{
    public delegate void EventHandler(object sender, Events e);

    public class Events : EventArgs
    {
        public string Str { get; set; }

        public Events(string str) {
            Str = str;
        }
    }

    public class Publisher() 
    {
        public event EventHandler Event;

        protected virtual void EventInvoke(string message)
        {
        }

        public void Printing()
        {
            EventInvoke("Event triggered");
        }
    }

    public class Subscriber
    {
        public void HandleMyEvent(object sender, Events e)
        {
            Console.WriteLine($"Event handled{e.Str}");
        }
    }

    
}
