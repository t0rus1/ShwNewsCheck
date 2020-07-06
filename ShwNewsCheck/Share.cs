using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShwNewsCheck
{
    public class Share : IComparable
    {
        public Share(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        private string name;
        private string number;

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }

        public override string ToString()
        {
            return $"{number} {name}";
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Share)obj).Name);
        }
    }

}
