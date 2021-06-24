using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Students(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
    }
}
