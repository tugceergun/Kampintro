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
    }
}
