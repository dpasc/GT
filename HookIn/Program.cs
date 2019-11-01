using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HookIn
{
    class Program
    {
        static void Main(string[] args)
        {
            GTContext gt = new GTContext();

            IEnumerable<CityAttraction> cityAttractions = gt.CityAttractions.ToList();
            
            foreach(var i in cityAttractions)
            {
                Console.WriteLine(i.Name);
            }




            Console.Read();

        }
    }
}
