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
        public string FulltName { get; set; }
        public int Age { get; set; }
        public Degree Degree { get; set; }
        public int Experience { get; set; }
        public string Company { get; set; }
        public Position Job { get; set; }

        public Developer()
        {

        }
    }
}
