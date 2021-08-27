using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //ihtiyaç kredisi
    class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer loan payment schedule calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
