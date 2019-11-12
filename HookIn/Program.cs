
using Domain.Data;
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

            //var gTContext = new GTContext();

            //var car = new CityAttractionsRepository(gTContext);
            //var peo = new PersonRepository(gTContext);
            //var tpc = new TravelPackageCityRepository(gTContext);





            //Create City Attraction
            //CityAttraction ca = new CityAttraction()
            //{
            //    Name = "Zoo",
            //    Description = "Checkout the animals",
            //    CityId = 1036007778

            //};
            //Task.Run(async () => { await car.Add(ca); });


            //Get CA


            //var checkCa2 = gTContext.CityAttractions.FirstOrDefault(ca => ca.Id == 9);


            //var ca = new CityAttraction();

            

            //Task.Run(async () => {  ca = await car.GetCA(7); });


            //Console.WriteLine(ca.Name);



            //Create new Customer 

            //Task.Run(async () => { await peo.AddEmployee("Sam", "Smith"); });

            //New TravelPackage
            //Task.Run(async () => { await tpc.AddTPC(1, 1012850542, 2); });

            //var otpc = gTContext.TravelPackageCities.FirstOrDefault();
            //Console.WriteLine(otpc.City.Name);

            //var travelPackageCity = tpc.Get(3);


            //Console.WriteLine(travelPackageCity.Id);



            Console.WriteLine("Done");

            Console.Read();

        }


    }


}

