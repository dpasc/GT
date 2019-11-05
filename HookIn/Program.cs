
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

            //var car = new CityAttractionsRepository(gTContext);
            var peo = new PersonRepository(gTContext);


            //City Attraction

            //Create City Attraction
            //CityAttraction ca = new CityAttraction()
            //{
            //    Name = "Zoo",
            //    Description = "Checkout the animals",
            //    CityId = 1036842122

            //};
            //Task.Run(async () => { await car.AddCA(ca); });

            ////Create new Customer 
        
            Task.Run(async () => { await peo.AddCustomer("John","Smith" ); });

            Console.WriteLine("Done");

            Console.Read();

        }


    }


}

