
using Domain.Data.MainRepository.Repositories;
using Library.Models;
using Library.Models.Models;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookIn
{
    class Program
    {

        static void Main(string[] args)
       {

            var gTContext = new GTContext();
            var tpr = new TravelProviderRepository(gTContext);
            var car = new CityAttractionsRepository(gTContext);


         //Travel Provider

            //Create are new travel provider
            TravelProvider tp = new TravelProvider()
            {
                Name = "Lambda Travel"
            };
            //Task.Run(async () => { await tpr.AddTP(tp); });


            //City Attraction

            //Create City Attraction
            CityAttraction ca = new CityAttraction()
            {
                Name = "Bobs Burgers",
                Description = "Get a burger",
                CityId = 1036842122

            };
            //Task.Run(async () => { await car.AddCA(ca); });





            Console.Read();

        }


    }


}

