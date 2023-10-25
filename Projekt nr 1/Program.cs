using LAB2.Constructions;
using System;

namespace Projekt_nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32,23,3,6,"brik");
            Console.WriteLine(constr.HumanCapacity);
        }
    }
}
