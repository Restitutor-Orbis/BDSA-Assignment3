using System.Collections.Generic;
using System;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {

        public IEnumerable<string> returnNamesInventedByRowlingLinq(IEnumerable<Wizard> wizards) {

            var output = from w in wizards
                         where w.Creator.Equals("J.K Rowling")
                         select w.Name;

            return output; 
        }

        public IEnumerable<string> returnNamesInventedByRowlingExtension(IEnumerable<Wizard> wizards) {

            var output = wizards.Where(w => w.Creator.Equals("J.K Rowling")).Select(w => w.Name);
            return output;
        }
          
        public int? FindFirstSithLordLinq(IEnumerable<Wizard> wizards) 
        {
            var output = (from w in wizards
                         where w.Name.Contains("Darth")
                         orderby w.Year
                         select w.Year).First();
            return output;
        }  

        public int? FindFirstSithLordExtension(IEnumerable<Wizard> wizards) {
            var output = wizards.Where(w => w.Name.Contains("Darth")).Select(w => w.Year).First();
            return output;
        }
    }
}
