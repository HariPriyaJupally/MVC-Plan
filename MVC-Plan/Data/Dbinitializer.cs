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

                    new Degree{DegreeID=2, DegreeAbbrev="ACS+DB", DegreeName="MS ACS + DB"},


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

                   

                };
                Console.WriteLine($"New requirement {team_6.Length} new requirement in inserted");
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
                Console.WriteLine($"New studentTerm {team_6.Length} new studentTerm in inserted");
                foreach (StudentTerm d in team_6)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE
            //This section is for Student
            if (context.Students.Any())
            {
                Console.WriteLine("Student exists.");
            }
            else
            {
                var team_6 = new Student[]
                {

                    new Student{StudentID=533990,FirstName="Hari Priya",LastName="Jupally",bearcatNum=919569151},
                    new Student{StudentID=531366,FirstName="Bharadwaj",LastName="Dasari",bearcatNum=919559663},
                    new Student{StudentID=533710,FirstName="Durga Susmitha",LastName="Kotyada",bearcatNum=919570698},
                    new Student{StudentID=533626,FirstName="Hyndavi",LastName="Musipatla",bearcatNum=919570835},
                    new Student{StudentID=531383,FirstName="Vyshnavi",LastName="Yalamareddy",bearcatNum=919562271},


                };
                Console.WriteLine($"New student {team_6.Length} new student in inserted");
                foreach (Student d in team_6)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE

            //This section is for DegreeRequirement
            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("DegreeRequirement exists.");
            }
            else
            {
                var team_6 = new DegreeRequirement[]
                {

                    new DegreeRequirement{DegreeRequirementID=1,DegreeID=2,RequirementID=460},
                    new DegreeRequirement{DegreeRequirementID=2,DegreeID=2,RequirementID=542},
                    new DegreeRequirement{DegreeRequirementID=3,DegreeID=2,RequirementID=563},
                    new DegreeRequirement{DegreeRequirementID=4,DegreeID=2,RequirementID=560},
                    new DegreeRequirement{DegreeRequirementID=5,DegreeID=2,RequirementID=555},
                    new DegreeRequirement{DegreeRequirementID=6,DegreeID=2,RequirementID=618},
                    new DegreeRequirement{DegreeRequirementID=7,DegreeID=2,RequirementID=1},
                    new DegreeRequirement{DegreeRequirementID=8,DegreeID=2,RequirementID=664},
                    new DegreeRequirement{DegreeRequirementID=9,DegreeID=2,RequirementID=10},
                    new DegreeRequirement{DegreeRequirementID=10,DegreeID=2,RequirementID=20},
                    new DegreeRequirement{DegreeRequirementID=11,DegreeID=2,RequirementID=691},
                    new DegreeRequirement{DegreeRequirementID=12,DegreeID=2,RequirementID=692},




                };
                Console.WriteLine($"New degreeRequirement {team_6.Length} new degreeRequirement in inserted");
                foreach (DegreeRequirement d in team_6)
                {
                    context.DegreeRequirements.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE

            //This section is for DegreePlan
            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlan exists.");
            }
            else
            {
                var team_6 = new DegreePlan[]
                {

                    new DegreePlan{DegreePlanID=12,DegreeID=2,StudentID=533990,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=2,StudentID=533990,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=12,DegreeID=2,StudentID=531366,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=2,StudentID=531366,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=12,DegreeID=2,StudentID=533710,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=2,StudentID=533710,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=12,DegreeID=2,StudentID=533626,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=2,StudentID=533626,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=12,DegreeID=2,StudentID=531383,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=2,StudentID=531383,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},



                };
                Console.WriteLine($"New student {team_6.Length} new student in inserted");
                foreach (DegreePlan d in team_6)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE

            //This section is for DegreePlanTermRequirement
            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlanTermRequirement exists.");
            }
            else
            {
                var team_6 = new DegreePlanTermRequirement[]
                {

                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=1,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=1,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=1,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=2,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=2,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=2,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=3,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=3,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=3,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=4,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=4,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=4,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=1,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=1,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=1,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=2,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=2,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=2,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=4,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=4,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=4,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=5,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=5,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=5,RequirementID=692},



                };
                Console.WriteLine($"New DegreePlanTermRequirement {team_6.Length} new DegreePlanTermRequirement in inserted");
                foreach (DegreePlanTermRequirement d in team_6)
                {
                    context.DegreePlanTermRequirements.Add(d);
                }
                context.SaveChanges();
            }
            //END HERE

        }
    }
}