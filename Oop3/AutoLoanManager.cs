using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //araç kredisi
    class AutoLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Car loan payment schedule calculated.");
            
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
