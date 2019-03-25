using JuniorDeveloperExercisesCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuniorDevCSharp.Enums.Degree;
using static JuniorDevCSharp.Enums.Position;

namespace JuniorDevCSharp
{
    public static class LINQ
    {
        private static List<Developer> _developersList;
        public static List<Developer> DevelopersList
        {
            get
            {
                return _developersList ?? new List<Developer> {
                    new Developer { Id =  123, Age = 26, Company = "Amazon", Degree = BS, Experience = 3, FulltName = "Avi Cohem", Job = JUNIOR },
                    new Developer { Id =  432, Age = 29, Company = "Google", Degree = MBA, Experience = 5, FulltName = "Dany Gur", Job = FULLSTACK },
                    new Developer { Id =  518, Age = 31, Company = "Microsoft", Degree = BS, Experience = 8, FulltName = "Eli Levy", Job = SENIOR },
                    new Developer { Id =  999, Age = 33, Company = "Facebook", Degree = BS, Experience = 6, FulltName = "Yossi Tsuk", Job = FRONTEND },
                    new Developer { Id =  999, Age = 33, Company = "Twistlock", Degree = MBA, Experience = 4, FulltName = "Moshe Green", Job = BACKEND }
                };
            }
        }
    }
}
