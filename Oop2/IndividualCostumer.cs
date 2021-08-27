using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //bireysel,gerçek müşteri
    class IndividualCostumer :Costumer //inheritance,kalıtım
    {
        
        public string TcNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
