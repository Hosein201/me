using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace phonbook2
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Famliy { get; set; }
        public string  Phone { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Famliy}-{Phone}";
        }
        public override bool Equals (object obj)
        {
            if (obj is Person)
            {
                var other = obj as Person;
                return other.Name == this.Name && other.Famliy == this.Famliy;
            }
            else return false;
        }

       

        public override int GetHashCode()
        {
            return Id;
               
        }

        
    }
}
