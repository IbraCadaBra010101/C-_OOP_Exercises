using System;

namespace week5
{
    class Teacher : Person
    {
        public long Salary
        {
            get;
            set;
        }

        public Teacher(string name, int age, string email, string address, long salary) : base(name, age, email, address)
        {
            Salary = salary;
        }
        public void GradeStudent(Student student)
        {
            Console.WriteLine("Student {0}'s grade set to {1}", student.Name, student.AverageGrade = "VG");
        }

        internal override void Print()
        {
            var person = $"Name: {Name}\nAge: {this.Name}\nEmail: {Email}\nAddress: {Address}\nSalary: {Salary}";
            Console.WriteLine(person);
        }
    }
}