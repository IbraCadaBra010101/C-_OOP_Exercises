using System;

namespace week5
{
    class Student : Person
    {


        public string AverageGrade
        {
            get;
            set;
        }

        public Student(string name, int age, string email, string address, string averageGrade) : base(name, age, email, address)
        {
            AverageGrade = averageGrade;
        }

        internal override void Print()
        {
            var person = $"Name: {Name}\nAge: {this.Name}\nEmail: {Email}\nAddress: {Address}\nAverage grade: {AverageGrade}";
            Console.WriteLine(person);
        }
    }
}