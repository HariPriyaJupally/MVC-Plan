﻿using System;
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

                    new Student{StudentID=533990,FirstName="Hari Priya",LastName="Jupally",bearcatNum="919569151"},
                    new Student{StudentID=531366,FirstName="Bharadwaj",LastName="Dasari",bearcatNum="919559663"},
                    new Student{StudentID=533710,FirstName="Durga Susmitha",LastName="Kotyada",bearcatNum="919570698"},
                    new Student{StudentID=533626,FirstName="Hyndavi",LastName="Musipatla",bearcatNum="919570835"},
                    new Student{StudentID=531383,FirstName="Vyshnavi",LastName="Yalamareddy",bearcatNum="919562271"},


                };
                Console.WriteLine($"New student {team_6.Length} new student in inserted");
                foreach (Student d in team_6)
                {
                    context.Students.Add(d);
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

                    new DegreePlan{DegreePlanID=1,DegreeID=2,StudentID=533990,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=2,DegreeID=2,StudentID=533990,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=3,DegreeID=2,StudentID=531366,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=4,DegreeID=2,StudentID=531366,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=5,DegreeID=2,StudentID=533710,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=6,DegreeID=2,StudentID=533710,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=7,DegreeID=2,StudentID=533626,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=8,DegreeID=2,StudentID=533626,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},
                    new DegreePlan{DegreePlanID=9,DegreeID=2,StudentID=531383,DegreePlanAbbrev="No Summer Off",DegreePlanName="No Summer Off"},
                    new DegreePlan{DegreePlanID=10,DegreeID=2,StudentID=531383,DegreePlanAbbrev="Summer Off",DegreePlanName="Summer Off"},



                };
                Console.WriteLine($"New student {team_6.Length} new student in inserted");
                foreach (DegreePlan d in team_6)
                {
                    context.DegreePlans.Add(d);
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

                   new StudentTerm{StudentTermId=1,StudentID=533990,TermID=1,TermName="Fall 2017", DegreePlanID=1},
                        new StudentTerm{StudentTermId=2,StudentID=533990,TermID=2,TermName="Spring 2018", DegreePlanID=1},
                        new StudentTerm{StudentTermId=3,StudentID=533990,TermID=3,TermName="Summer 2018", DegreePlanID=1},
                        new StudentTerm{StudentTermId=4,StudentID=533990,TermID=4,TermName="Fall 2018", DegreePlanID=1},
                        new StudentTerm{StudentTermId=5,StudentID=533990,TermID=5,TermName="Spring 2019", DegreePlanID=1},
                        new StudentTerm{StudentTermId=6,StudentID=531366,TermID=1,TermName="Fall 2017", DegreePlanID=3},
                        new StudentTerm{StudentTermId=7,StudentID=531366,TermID=2,TermName="Spring 2018", DegreePlanID=3},
                        new StudentTerm{StudentTermId=8,StudentID=531366,TermID=3,TermName="Summer 2018", DegreePlanID=3},
                        new StudentTerm{StudentTermId=9,StudentID=531366,TermID=4,TermName="Fall 2018", DegreePlanID=3},
                        new StudentTerm{StudentTermId=10,StudentID=531366,TermID=5,TermName="Spring 2019", DegreePlanID=3},
                        new StudentTerm{StudentTermId=11,StudentID=533710,TermID=1,TermName="Fall 2017", DegreePlanID=5},
                        new StudentTerm{StudentTermId=12,StudentID=533710,TermID=2,TermName="Spring 2018", DegreePlanID=5},
                        new StudentTerm{StudentTermId=13,StudentID=533710,TermID=3,TermName="Summer 2018", DegreePlanID=5},
                        new StudentTerm{StudentTermId=14,StudentID=533710,TermID=4,TermName="Fall 2018", DegreePlanID=5},
                        new StudentTerm{StudentTermId=15,StudentID=533710,TermID=5,TermName="Spring 2019", DegreePlanID=5},
                        new StudentTerm{StudentTermId=16,StudentID=533626,TermID=1,TermName="Fall 2017", DegreePlanID=7},
                        new StudentTerm{StudentTermId=17,StudentID=533626,TermID=2,TermName="Spring 2018", DegreePlanID=7},
                        new StudentTerm{StudentTermId=18,StudentID=533626,TermID=3,TermName="Summer 2018", DegreePlanID=7},
                        new StudentTerm{StudentTermId=19,StudentID=533626,TermID=4,TermName="Fall 2018", DegreePlanID=7},
                        new StudentTerm{StudentTermId=20,StudentID=533626,TermID=5,TermName="Spring 2019", DegreePlanID=7},
                        new StudentTerm{StudentTermId=21,StudentID=531383,TermID=1,TermName="Fall 2017", DegreePlanID=9},
                        new StudentTerm{StudentTermId=22,StudentID=531383,TermID=2,TermName="Spring 2018", DegreePlanID=9},
                        new StudentTerm{StudentTermId=23,StudentID=531383,TermID=3,TermName="Summer 2018", DegreePlanID=9},
                        new StudentTerm{StudentTermId=24,StudentID=531383,TermID=4,TermName="Fall 2018", DegreePlanID=9},
                        new StudentTerm{StudentTermId=25,StudentID=531383,TermID=5,TermName="Spring 2019", DegreePlanID=9},

                };
                Console.WriteLine($"New studentTerm {team_6.Length} new studentTerm in inserted");
                foreach (StudentTerm d in team_6)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
            //END HEREs


            

            //This section is for Requirements
            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirement exists.");
            }
            else
            {
                var team_6 = new Requirement[]
                {

                    new Requirement{ RequirementID= 460,RequirementAbbrev= "DB",RequirementName = "44-460 Database", DegreeID=2, StudentTermId=1},
                    new Requirement{ RequirementID= 542,RequirementAbbrev= "OOP",RequirementName = "44-542 OOP", DegreeID=2, StudentTermId=1},
                    new Requirement{ RequirementID= 563,RequirementAbbrev= "Web apps",RequirementName = "44-563 Web apps", DegreeID=2, StudentTermId=1},
                    new Requirement{ RequirementID= 560,RequirementAbbrev= "ADB",RequirementName = "44-560 ADB", DegreeID=2, StudentTermId=1},
                    new Requirement{ RequirementID= 555,RequirementAbbrev= "NS",RequirementName = "44-555 Network Security", DegreeID=2, StudentTermId=2},
                    new Requirement{ RequirementID= 618,RequirementAbbrev= "PM",RequirementName = "44-618 PM", DegreeID=2, StudentTermId=2},
                    new Requirement{ RequirementID= 1,RequirementAbbrev= "Mobile",RequirementName = "44-643 or 44-644", DegreeID=2, StudentTermId=2},
                    new Requirement{ RequirementID= 664,RequirementAbbrev= "UXD",RequirementName = "44-664 UXD", DegreeID=2, StudentTermId=3},
                    new Requirement{ RequirementID= 10,RequirementAbbrev= "E1",RequirementName = "Elective 1", DegreeID=2, StudentTermId=3},
                    new Requirement{ RequirementID= 20,RequirementAbbrev= "E2",RequirementName = "Elective 2", DegreeID=2, StudentTermId=3},
                    new Requirement{ RequirementID= 691,RequirementAbbrev= "GDP1",RequirementName = "GDP1", DegreeID=2, StudentTermId=4},
                    new Requirement{ RequirementID= 692,RequirementAbbrev= "GDP2",RequirementName = "GDP2", DegreeID=2, StudentTermId=4}

                   

                };
                Console.WriteLine($"New requirement {team_6.Length} new requirement in inserted");
                foreach (Requirement d in team_6)
                {
                    context.Requirements.Add(d);
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

                    new DegreeRequirement{DegreeRequirementID=1,StudentTermID=1,RequirementID=460},
                    new DegreeRequirement{DegreeRequirementID=2,StudentTermID=1,RequirementID=542},
                    new DegreeRequirement{DegreeRequirementID=3,StudentTermID=1,RequirementID=563},
                    new DegreeRequirement{DegreeRequirementID=4,StudentTermID=1,RequirementID=560},
                    new DegreeRequirement{DegreeRequirementID=5,StudentTermID=1,RequirementID=555},
                    new DegreeRequirement{DegreeRequirementID=6,StudentTermID=1,RequirementID=618},
                    new DegreeRequirement{DegreeRequirementID=7,StudentTermID=1,RequirementID=1},
                    new DegreeRequirement{DegreeRequirementID=8,StudentTermID=1,RequirementID=664},
                    new DegreeRequirement{DegreeRequirementID=9,StudentTermID=1,RequirementID=10},
                    new DegreeRequirement{DegreeRequirementID=10,StudentTermID=1,RequirementID=20},
                    new DegreeRequirement{DegreeRequirementID=11,StudentTermID=1,RequirementID=691},
                    new DegreeRequirement{DegreeRequirementID=12,StudentTermID=1,RequirementID=692},




                };
                Console.WriteLine($"New degreeRequirement {team_6.Length} new degreeRequirement in inserted");
                foreach (DegreeRequirement d in team_6)
                {
                    context.DegreeRequirements.Add(d);
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

                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=1,TermID=1,DegreePlanID=1,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=2,TermID=1,DegreePlanID=1,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=3,TermID=1,DegreePlanID=1,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=4,TermID=2,DegreePlanID=1,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=5,TermID=2,DegreePlanID=1,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=6,TermID=2,DegreePlanID=1,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=7,TermID=3,DegreePlanID=1,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=8,TermID=3,DegreePlanID=1,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=9,TermID=3,DegreePlanID=1,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=10,TermID=4,DegreePlanID=1,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=11,TermID=4,DegreePlanID=1,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,TermID=4,DegreePlanID=1,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,TermID=1,DegreePlanID=2,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=14,TermID=1,DegreePlanID=2,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=15,TermID=1,DegreePlanID=2,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=16,TermID=2,DegreePlanID=2,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=17,TermID=2,DegreePlanID=2,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=18,TermID=2,DegreePlanID=2,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=19,TermID=4,DegreePlanID=2,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=20,TermID=4,DegreePlanID=2,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=21,TermID=4,DegreePlanID=2,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=22,TermID=5,DegreePlanID=2,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=23,TermID=5,DegreePlanID=2,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=24,TermID=5,DegreePlanID=2,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=25,TermID=1,DegreePlanID=3,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=26,TermID=1,DegreePlanID=3,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=27,TermID=1,DegreePlanID=3,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=28,TermID=2,DegreePlanID=3,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=29,TermID=2,DegreePlanID=3,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=30,TermID=2,DegreePlanID=3,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=31,TermID=3,DegreePlanID=3,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=32,TermID=3,DegreePlanID=3,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=33,TermID=3,DegreePlanID=3,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=34,TermID=4,DegreePlanID=3,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=35,TermID=4,DegreePlanID=3,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=36,TermID=4,DegreePlanID=3,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=37,TermID=1,DegreePlanID=4,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=38,TermID=1,DegreePlanID=4,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=39,TermID=1,DegreePlanID=4,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=40,TermID=2,DegreePlanID=4,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=41,TermID=2,DegreePlanID=4,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=42,TermID=2,DegreePlanID=4,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=43,TermID=4,DegreePlanID=4,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=44,TermID=4,DegreePlanID=4,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=45,TermID=4,DegreePlanID=4,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=46,TermID=5,DegreePlanID=4,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=47,TermID=5,DegreePlanID=4,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=48,TermID=5,DegreePlanID=4,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=49,TermID=1,DegreePlanID=5,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=50,TermID=1,DegreePlanID=5,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=51,TermID=1,DegreePlanID=5,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=52,TermID=2,DegreePlanID=5,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=53,TermID=2,DegreePlanID=5,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=54,TermID=2,DegreePlanID=5,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=55,TermID=3,DegreePlanID=5,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=56,TermID=3,DegreePlanID=5,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=57,TermID=3,DegreePlanID=5,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=58,TermID=4,DegreePlanID=5,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=59,TermID=4,DegreePlanID=5,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=60,TermID=4,DegreePlanID=5,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=61,TermID=1,DegreePlanID=6,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=62,TermID=1,DegreePlanID=6,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=63,TermID=1,DegreePlanID=6,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=64,TermID=2,DegreePlanID=6,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=65,TermID=2,DegreePlanID=6,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=66,TermID=2,DegreePlanID=6,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=67,TermID=4,DegreePlanID=6,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=68,TermID=4,DegreePlanID=6,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=69,TermID=4,DegreePlanID=6,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=70,TermID=5,DegreePlanID=6,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=71,TermID=5,DegreePlanID=6,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=72,TermID=5,DegreePlanID=6,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=73,TermID=1,DegreePlanID=7,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=74,TermID=1,DegreePlanID=7,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=75,TermID=1,DegreePlanID=7,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=76,TermID=2,DegreePlanID=7,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=77,TermID=2,DegreePlanID=7,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=78,TermID=2,DegreePlanID=7,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=79,TermID=3,DegreePlanID=7,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=80,TermID=3,DegreePlanID=7,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=81,TermID=3,DegreePlanID=7,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=82,TermID=4,DegreePlanID=7,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=83,TermID=4,DegreePlanID=7,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=84,TermID=4,DegreePlanID=7,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=85,TermID=1,DegreePlanID=8,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=86,TermID=1,DegreePlanID=8,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=87,TermID=1,DegreePlanID=8,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=88,TermID=2,DegreePlanID=8,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=89,TermID=2,DegreePlanID=8,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=90,TermID=2,DegreePlanID=8,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=91,TermID=4,DegreePlanID=8,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=92,TermID=4,DegreePlanID=8,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=93,TermID=4,DegreePlanID=8,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=94,TermID=5,DegreePlanID=8,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=95,TermID=5,DegreePlanID=8,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=96,TermID=5,DegreePlanID=8,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=97,TermID=1,DegreePlanID=9,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=98,TermID=1,DegreePlanID=9,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=99,TermID=1,DegreePlanID=9,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=100,TermID=2,DegreePlanID=9,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=101,TermID=2,DegreePlanID=9,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=102,TermID=2,DegreePlanID=9,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=103,TermID=3,DegreePlanID=9,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=104,TermID=3,DegreePlanID=9,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=105,TermID=3,DegreePlanID=9,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=106,TermID=4,DegreePlanID=9,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=107,TermID=4,DegreePlanID=9,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=108,TermID=4,DegreePlanID=9,RequirementID=692},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=109,TermID=1,DegreePlanID=10,RequirementID=460},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=110,TermID=1,DegreePlanID=10,RequirementID=542},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=111,TermID=1,DegreePlanID=10,RequirementID=563},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=112,TermID=2,DegreePlanID=10,RequirementID=560},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=113,TermID=2,DegreePlanID=10,RequirementID=555},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=114,TermID=2,DegreePlanID=10,RequirementID=618},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=115,TermID=4,DegreePlanID=10,RequirementID=1},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=116,TermID=4,DegreePlanID=10,RequirementID=664},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=117,TermID=4,DegreePlanID=10,RequirementID=10},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=118,TermID=5,DegreePlanID=10,RequirementID=20},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=119,TermID=5,DegreePlanID=10,RequirementID=691},
                    new DegreePlanTermRequirement{DegreePlanTermRequirementID=120,TermID=5,DegreePlanID=10,RequirementID=692},




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