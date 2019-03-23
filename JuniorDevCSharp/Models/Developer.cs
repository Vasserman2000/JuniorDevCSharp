using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuniorDevCSharp.Enums;

namespace JuniorDeveloperExercisesCSharp.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Degree Degree { get; set; }
        public int Experience { get; set; }
        public bool IsWorking { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
    }
}
