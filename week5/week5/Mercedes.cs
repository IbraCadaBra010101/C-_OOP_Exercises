
using System.Collections.Generic;

namespace week5
{
    class Mercedes : Car
    {
        public List<Car> listOfCars { get; set; }
        public Mercedes(string brandName, int brandFoundationYear, string countryOfOrigin, string motherCompany) : base(brandName, brandFoundationYear, countryOfOrigin, motherCompany)
        {
        }
    }
}