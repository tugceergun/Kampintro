using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //başvuru
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager) //herkesin referansını tutabilen ICreditManager'ı parametre yaptık.
        {
            //başvuran bilgilerini değerlendirme
            //

            creditManager.Calculate();
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
