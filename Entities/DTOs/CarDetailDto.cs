using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        //rabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice

        public string  CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal  DailyPrice { get; set; }


    }
}
