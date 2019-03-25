using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuniorDevCSharp.LINQ;
using static JuniorDevCSharp.Enums.Position;

namespace JuniorDevCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GET ALL JUNIOR DEVELOPERS
            var juniors = DevelopersList.Where(dev => dev.Job == JUNIOR);
        }
    }
}
