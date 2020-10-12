using System;
using System.Collections.Generic;

namespace week5
{
    class Car
    {
        public string BrandName { get; set; }
        public int BrandFoundationYear { get; set; }
        public string CountryOfOrigin { get; set; }
        public string MotherCompany { get; set; }
        public List<Toyota> ListOfCars = new List<Toyota>() { };

        public Car(string brandName, int brandFoundationYear, string countryOfOrigin, string motherCompany)
        {
            BrandName = brandName;

            BrandFoundationYear = brandFoundationYear;
            CountryOfOrigin = countryOfOrigin;
            MotherCompany = motherCompany;
        }
        public virtual void PrintCarInfo()
        {
             
                Console.WriteLine($"Brand: {BrandName} Founded: {BrandFoundationYear} Origin: {CountryOfOrigin} Owner: {MotherCompany}");
        }
    }
}