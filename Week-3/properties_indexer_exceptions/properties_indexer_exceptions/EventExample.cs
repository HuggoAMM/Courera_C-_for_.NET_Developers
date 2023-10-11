using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_indexer_exceptions
{
    // Publisher Model Event
    internal class EventExample
    {

        public delegate void delegate_OddNumber();

        public event delegate_OddNumber event_OddNumber;

        public void Addition()
        {
            int num1 = 100;
            int num2 = 200;
            int result = num1 + num2;
            Console.WriteLine(result);
            if(result % 2 != 0 && event_OddNumber != null)
            {
                event_OddNumber();
            }
        }
    }
}
