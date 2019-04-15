using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JuniorDevCSharp.LINQ;
using static JuniorDevCSharp.Enums.Position;
using System.Collections;

namespace JuniorDevCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GET ALL JUNIOR DEVELOPERS
            var juniors = DevelopersList.Where(dev => dev.Job == JUNIOR);


            IList mixList = new ArrayList();
            mixList.Add(4);
            mixList.Add("Shalom");
            mixList.Add(91);
            mixList.Add(true);
            mixList.Add(11);
            mixList.Add("Jhonny");
            mixList.Add(19.184);
            mixList.Add(new { Name = "Adam", Age = 30 });

            int sum = mixList.OfType<int>().Sum();
            string sentence = mixList.OfType<string>().Aggregate("", (current, next) => current + " " + next);
            Console.WriteLine(sum);
            Console.WriteLine(sentence);
        }
    }
}
