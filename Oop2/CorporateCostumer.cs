using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Tüzel Müşteri
    class CorporateCostumer :Costumer //inheritance,kalıtım
    {
        
        public string CompanyName { get; set; }
        public string TaxNum { get; set; }

        //sayısal bir işlem yapmayacaksan sayılara long,int vermek yerine metinsel bir değer gibi düşünüp string verebilirsin.
    }
}
