using Domain.Repository;
using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookIn
{
    class Program
    {
        private TravelProviderRepository _tp;
        public Program(TravelProviderRepository tp)
        {
            this._tp = tp;
        }
        static void Main(string[] args)
       {
            TravelProviderRepository tpr = new TravelProviderRepository();

            TravelProvider tp = new TravelProvider()
            {
                Name = " Travellin Places"
            };

            tpr.Insert(tp);
            tpr.Save();

            Console.Read();

        }


    }
}

