using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.Id = 1;
            costumer1.CostumerNum = "12345";
            costumer1.Name = "Tuğçe";
            costumer1.Surname = "Ergün";
            costumer1.TcNum = "12345678910";

            CorporateCostumer costumer2 = new CorporateCostumer();
            costumer2.Id = 2;
            costumer2.CostumerNum = "54321";
            costumer2.CompanyName = "Kodlama.io";
            costumer2.TaxNum = "1234567890";

            Costumer costumer3 = new IndividualCostumer();  //Costumer sınıfı hem indivudual costumer sınıfının referansını tutabiliyor.//new deyince akla referans gelmeli.
            Costumer costumer4 = new CorporateCostumer();   // hem de Corporate costumer sınıfının referansını tutabiliyor.

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer2);
            costumerManager.Add(costumer3);

        }
    }
}
