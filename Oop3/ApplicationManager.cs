using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //başvuru
    class ApplicationManager
    {
        //Method injection (Methodun kullanacağı kredi türünün ne olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.)
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices) //herkesin referansını tutabilen ICreditManager'ı parametre yaptık.
        {                                                                                  //Loglama işlemini de ekledik.(birden fazla seçilebileceği için liste yaptık.)
            //başvuran bilgilerini değerlendirme
            //

            creditManager.Calculate();

            foreach (var loggerService in loggerServices)  //birden fazla logger servisi seçebiliriz.
            {
                loggerService.Log();    //her bir loglayıcıyı çalıştır.
            }
        }

        public void CreditPreInfo(List<ICreditManager> credits)  //başvuru ön bilgilendirmesi.//birçok kredi türü olabilir o yüzden ICreditManager türünde yaptık.
        {
            foreach (var credit in credits)  //listedeki her bir kredinin bir hesabını yap.
            {
                credit.Calculate();
            }
        }
    }
}
