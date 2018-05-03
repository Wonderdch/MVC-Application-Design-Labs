using System;
using ModelDesignLab.Models;
using System.Linq;

namespace ModelDesignLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new sakilaContext())
            {
                var actors = dbContext.Actor.ToList();
                foreach (var a in actors)
                {
                    Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
                }
            }
        }
    }
}
