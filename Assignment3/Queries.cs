using System.Collections.Generic;
using System;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {

        public IEnumerable<string> ReturnNamesInventedByRowlingLinq(IEnumerable<Wizard> wizards) 
        {
            var output = from w in wizards
                         where w.Creator.Equals("J.K Rowling")
                         select w.Name;

            return output; 
        }

        public IEnumerable<string> ReturnNamesInventedByRowlingExtension(IEnumerable<Wizard> wizards) 
        {
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

        public int? FindFirstSithLordExtension(IEnumerable<Wizard> wizards) 
        {
            var output = wizards.Where(w => w.Name.Contains("Darth")).Select(w => w.Year).First();
            return output;
        }

        public IEnumerable<(string, int?)> FindWizardsFromHarryPotterLinq(IEnumerable<Wizard> wizards)
        {
            var output = (from w in wizards
                         where w.Medium.Contains("Harry Potter")
                         select (w.Name, w.Year)).Distinct();
            return output;
        }

        public IEnumerable<(string, int?)> FindWizardsFromHarryPotterExtension(IEnumerable<Wizard> wizards)
        {
            var output = wizards.Where(w => w.Medium.Contains("Harry Potter"))
                                .Select(w => (w.Name, w.Year));
            return output;
        }

        public IEnumerable<string> ListWizardNamesLinq(IEnumerable<Wizard> wizards)
        {
            var output = from w in wizards
                         group w.Creator by new { w.Creator, w.Name } into newGroup
                         orderby newGroup.Key.Creator descending, newGroup.Key.Name ascending
                         select newGroup.Key.Name;

            return output;
        }

        public IEnumerable<string> ListWizardNamesExtension(IEnumerable<Wizard> wizards)
        {
            var output = wizards.GroupBy(w => new {w.Creator, w.Name})
                                .OrderByDescending(w => w.Key.Creator).ThenBy(w => w.Key.Name)
                                .Select(w => w.Key.Name);

            return output;
        }

    }
}
