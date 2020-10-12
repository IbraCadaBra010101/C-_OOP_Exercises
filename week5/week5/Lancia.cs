using System;

namespace week5
{
    class Lancia : Car
    {
        public int RallyWins { get; set; }
        public string Driver { get; set; }
        public Lancia(string brandName, int brandFoundationYear, string countryOfOrigin, string motherCompany, int rallyWins, string driver
            ) : base(brandName, brandFoundationYear, countryOfOrigin, motherCompany)
        {
            RallyWins = rallyWins;
            Driver = driver;
        }

        public override void PrintCarInfo()
        {
            Console.WriteLine($"Brand: {BrandName} Founded: {BrandFoundationYear} Origin: {CountryOfOrigin} Owner: {MotherCompany} Rally wins: {RallyWins} Driver: {Driver}");

        }
    } 
}
//Add a new car brand
//Add the new car brand Lancia it should be a child to the base class car. Lancia have the unique
//property rally wins which should have the starting value 15. Populate it using information from
//Wikipedia
//Create a method similar to the others that use car brand information to print shared properties but
//also prints Lancia specific properties