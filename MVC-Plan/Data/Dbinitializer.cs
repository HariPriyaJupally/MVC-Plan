using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Plan.Models;

namespace MVC_Plan.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Team_6.Any())
            {
                Console.WriteLine("Degree exists.");
            }
            else
            {
                var team_6 = new Degree[]
                {

                    new Degree{DegreeID = 2, DegreeAbbrive = "ACS+DB", DegreeName = "MS ACS+DB"},

                };
                Console.WriteLine($"New degree {team_6.Length} new degree in inserted");
                foreach (Degree d in team_6)
                {
                    context.Team_6.Add(d);
                }
                context.SaveChanges();
            }
        }
    }
}