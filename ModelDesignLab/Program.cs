using System;
using ModelDesignLab.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ModelDesignLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new sakilaContext())
            {
                // Reading
                // var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
                // foreach (var record in records)
                // {
                //     System.Console.WriteLine($"Film: {record.Title}");
                //     var counter = 1;
                //     foreach (var fa in record.FilmActor)
                //     {
                //         System.Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
                //     }
                // }

                // Creating
                // var city=new City(){CityId=1001,Name="Wonder",CountryId=103};
                // dbContext.Add(city);
                // dbContext.SaveChanges();

                // Updating
                // var uTarget=dbContext.City.SingleOrDefault(c=>c.CityId==1001);
                // if(uTarget!=null)
                // {
                //     uTarget.Name="Kirkland";
                //     dbContext.Update(uTarget);
                //     dbContext.SaveChanges();
                // }

                // Deleting
                var dTarget=dbContext.City.SingleOrDefault(c=>c.CityId==1001);
                if(dTarget!=null)
                {
                    dbContext.Remove(dTarget);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
