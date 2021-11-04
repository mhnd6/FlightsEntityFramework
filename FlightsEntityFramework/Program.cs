using DataAccess.FlightsDataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FlightsEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {


            //CreateFilght();
            AddPassenger("Amjad");
            ReadAll();
            Console.WriteLine("Done processing!");
            Console.ReadLine();
        }

        private static void CreateFilght()
        {
            using (var db = new FlightsContext())
            {
                var f = new Flight
                {
                    Reference = "ARB1199",
                    Destination = "Tokyo"
                };

                f.Passengers.Add(new Passenger
                {
                    FirstName = "Mohanned"
                });

                db.Flights.Add(f);
                db.SaveChanges();
            }
        }

        private static void AddPassenger(string passengerName)
        {
            using (var db = new FlightsContext())
            {
                var f = db.Flights.Where(fl => fl.Id == 2).First();

                f.Passengers.Add(new Passenger
                {
                    FirstName = passengerName
                });

                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new FlightsContext())
            {
                var records = db.Flights
                    .Include(f => f.Passengers)
                    .ToList();

                foreach (var flight in records)
                {
                    Console.WriteLine($"{flight.Reference} is going to {flight.Destination}");
                }
            }
        }
    }
}
