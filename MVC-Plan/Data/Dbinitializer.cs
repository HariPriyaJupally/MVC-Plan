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
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree exists.");
            }
            else
            {
                var team_6 = new Degree[]
                {

                    new Degree{DegreeID = 2, DegreeAbbrev = "ACS+DB", DegreeName = "MS ACS+DB"},

                };
                Console.WriteLine($"New degree {team_6.Length} new degree in inserted");
                foreach (Degree d in team_6)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }

//This section is for Requirements
            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirement exists.");
            }
            else
            {
                var team_6 = new Requirement[]
                {

                    new Requirement{ RequirementID= 460,RequirementAbbrev= "DB",RequirementName = "44-460 Database"},
                    new Requirement{ RequirementID= 542,RequirementAbbrev= "OOP",RequirementName = "44-542 OOP"},
                    new Requirement{ RequirementID= 563,RequirementAbbrev= "Web apps",RequirementName = "44-563 Web apps"},
                    new Requirement{ RequirementID= 560,RequirementAbbrev= "ADB",RequirementName = "44-560 ADB"},
                    new Requirement{ RequirementID= 555,RequirementAbbrev= "NS",RequirementName = "44-555 Network Security"},
                    new Requirement{ RequirementID= 618,RequirementAbbrev= "PM",RequirementName = "44-618 PM"},
                    new Requirement{ RequirementID= 1,RequirementAbbrev= "Mobile",RequirementName = "44-643 or 44-644"},
                    new Requirement{ RequirementID= 664,RequirementAbbrev= "UXD",RequirementName = "44-664 UXD"},
                    new Requirement{ RequirementID= 10,RequirementAbbrev= "E1",RequirementName = "Elective 1"},
                    new Requirement{ RequirementID= 20,RequirementAbbrev= "E2",RequirementName = "Elective 2"},
                    new Requirement{ RequirementID= 691,RequirementAbbrev= "GDP1",RequirementName = "GDP1"},
                    new Requirement{ RequirementID= 692,RequirementAbbrev= "GDP2",RequirementName = "GDP2"},

                    //new Degree{DegreeID = 2, DegreeAbbrev = "ACS+DB", DegreeName = "MS ACS+DB"},

                };
                Console.WriteLine($"New degree {team_6.Length} new degree in inserted");
                foreach (Requirement d in team_6)
                {
                    context.Requirements.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE
  //This section is for Student Term
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("StudentTerm exists.");
            }
            else
            {
                var team_6 = new StudentTerm[]
                {

                   new StudentTerm{StudentTermId=1,StudentID=533990,TermID=1,TermName="Fall 2017"},
                        new StudentTerm{StudentTermId=2,StudentID=533990,TermID=2,TermName="Spring 2018"},
                        new StudentTerm{StudentTermId=3,StudentID=533990,TermID=3,TermName="Summer 2018"},
                        new StudentTerm{StudentTermId=4,StudentID=533990,TermID=4,TermName="Fall 2018"},
                        new StudentTerm{StudentTermId=5,StudentID=533990,TermID=5,TermName="Spring 2019"},
                        new StudentTerm{StudentTermId=1,StudentID=531366,TermID=1,TermName="Fall 2017"},
                        new StudentTerm{StudentTermId=2,StudentID=531366,TermID=2,TermName="Spring 2018"},
                        new StudentTerm{StudentTermId=3,StudentID=531366,TermID=3,TermName="Summer 2018"},
                        new StudentTerm{StudentTermId=4,StudentID=531366,TermID=4,TermName="Fall 2018"},
                        new StudentTerm{StudentTermId=5,StudentID=531366,TermID=5,TermName="Spring 2019"},
                        new StudentTerm{StudentTermId=1,StudentID=533710,TermID=1,TermName="Fall 2017"},
                        new StudentTerm{StudentTermId=2,StudentID=533710,TermID=2,TermName="Spring 2018"},
                        new StudentTerm{StudentTermId=3,StudentID=533710,TermID=3,TermName="Summer 2018"},
                        new StudentTerm{StudentTermId=4,StudentID=533710,TermID=4,TermName="Fall 2018"},
                        new StudentTerm{StudentTermId=5,StudentID=533710,TermID=5,TermName="Spring 2019"},
                        new StudentTerm{StudentTermId=1,StudentID=533626,TermID=1,TermName="Fall 2017"},
                        new StudentTerm{StudentTermId=2,StudentID=533626,TermID=2,TermName="Spring 2018"},
                        new StudentTerm{StudentTermId=3,StudentID=533626,TermID=3,TermName="Summer 2018"},
                        new StudentTerm{StudentTermId=4,StudentID=533626,TermID=4,TermName="Fall 2018"},
                        new StudentTerm{StudentTermId=5,StudentID=533626,TermID=5,TermName="Spring 2019"},
                        new StudentTerm{StudentTermId=1,StudentID=531383,TermID=1,TermName="Fall 2017"},
                        new StudentTerm{StudentTermId=2,StudentID=531383,TermID=2,TermName="Spring 2018"},
                        new StudentTerm{StudentTermId=3,StudentID=531383,TermID=3,TermName="Summer 2018"},
                        new StudentTerm{StudentTermId=4,StudentID=531383,TermID=4,TermName="Fall 2018"},
                        new StudentTerm{StudentTermId=5,StudentID=531383,TermID=5,TermName="Spring 2019"},

                };
                Console.WriteLine($"New degree {team_6.Length} new studentTerm in inserted");
                foreach (StudentTerm d in team_6)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE

        }
    }
}