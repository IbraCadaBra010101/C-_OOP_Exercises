
using System;
using System.Collections.Generic;

namespace week5
{
    class Toyota : Car
    {
        private string Model { get; set; }
        private bool IsElectric { get; set; }
        public Toyota(string brandName, int brandFoundationYear, string countryOfOrigin, string motherCompany, string model, bool isElectric) 
            : base(brandName, brandFoundationYear, countryOfOrigin, motherCompany)
        {
            Model = model;
            IsElectric = isElectric;
        }

        public virtual void PrintCarInfo()
        {
            //Console.WriteLine($"Brand: {BrandName} Founded: {BrandFoundationYear} Country: {CountryOfOrigin}");
            foreach (var car in ListOfCars)
            {
                Console.WriteLine($"Model: {Model} Electric: {IsElectric} Brand: {car.BrandName} Founded: {BrandFoundationYear} Origin: {CountryOfOrigin} Owner: {MotherCompany}");

            }
        }

    }
}