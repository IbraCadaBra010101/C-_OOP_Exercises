using System;

namespace week5
{
    class Person
    {
        public string Name
        {
            get; 
            private set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        public Person(string name, int age, string email, string address)
        {
            Name = name;
            Age = age;
            Email = email;
            Address = address;
        }

        internal virtual void Print()
        {
            var person = $"Name: {Name}\nAge: {Age}\nEmail: {Email}\nAddress: {Address}";
            Console.WriteLine(person);
        }
    }
}