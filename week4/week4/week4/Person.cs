using System;

namespace week4
{
    public class Person
    { 
      
        public string FirstName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

         
        public Person(string firstName = "empty", int age = 0)
        {
            this.FirstName = $"{firstName} von Habsburg";
            this.Age = age; 
        }
    }
}