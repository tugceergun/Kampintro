using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //konut kredisi
    class HousingLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing loan payment schedule calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
