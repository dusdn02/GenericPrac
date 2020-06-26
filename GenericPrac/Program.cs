using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new GenericPrac.Wanted<string>("루피");
            Wanted<int> wantedInt = new GenericPrac.Wanted<int>(100);
            Wanted<double> wantedDouble = new GenericPrac.Wanted<double>(3.141592);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);
        }
    }
}
