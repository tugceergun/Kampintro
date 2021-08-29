using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager(); //kredi çeşitleri.
            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager autoLoanManager = new AutoLoanManager();
            //AutoLoanManager yerine ICreditManager dedik.
            //Yani interface'ler de; o interface'i implemente eden classın referans numarasını tutabiliyor.

            ILoggerService databeseLoggerServise = new DatabaseLoggerService();  //loglama.
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerLoanManager,new List<ILoggerService>(){databeseLoggerServise,fileLoggerService, });
            //hangi kredi çeşidinin olacağını ve hangi loglama servislerinin olacağını seçtik.

            List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager,autoLoanManager}; //iki kredi de müşteriye uyuyor.
            applicationManager.CreditPreInfo(credits);
        }
    }
}
