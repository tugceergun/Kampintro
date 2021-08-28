using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager autoLoanManager = new AutoLoanManager();
            //AutoLoanManager yerine ICreditManager dedik.
            //Yani interface'ler de; o interface'i implemente eden classın referans numarasını tutabiliyor.

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerLoanManager);

            List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager,autoLoanManager}; //iki kredi de müşteriye uyuyor.
            applicationManager.CreditPreInfo(credits);
        }
    }
}
