using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace task17._using_Cs
{
    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name} : {Age}");
        public Person()
        {
            Name = "Wilson";
            Age = 15;
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
