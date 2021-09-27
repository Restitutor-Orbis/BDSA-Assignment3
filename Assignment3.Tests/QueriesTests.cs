using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Only_return_names_of_wizards_invented_by_rowling_linq()
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Troldmand1", "Troldmand2"};

            var actual = queries.ReturnNamesInventedByRowlingLinq(wizards);

            Assert.Equal(expected, actual);
        }   

        [Fact]
        public void Only_return_names_of_wizards_invented_by_rowling_extension() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Troldmand1", "Troldmand2"};

            var actual = queries.ReturnNamesInventedByRowlingExtension(wizards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_the_first_sithlord_linq() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = 1977;

            var actual = queries.FindFirstSithLordLinq(wizards);

            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void Return_the_first_sithlord_extension() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = 1977;

            var actual = queries.FindFirstSithLordExtension(wizards);

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Unique_list_Harry_Potter_retruns_name_and_year_as_tuple_linq() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<(string, int?)> {
                ("Troldkvinde1", 1948),
                ("Troldkvinde2", 1948)
            };

            var actual = queries.FindWizardsFromHarryPotterLinq(wizards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Unique_list_Harry_Potter_retruns_name_and_year_as_tuple_extension() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<(string, int?)> {
                ("Troldkvinde1", 1948),
                ("Troldkvinde2", 1948)
            };

            var actual = queries.FindWizardsFromHarryPotterExtension(wizards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_of_wizard_names_grouped_by_creator_DSC_and_name_linq() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {
                "Darth Fiona",
                "Darth Shrek",
                "Sauron",
                "Troldmand1",
                "Troldmand2",
                "Troldkvinde1",
                "Troldkvinde2",
                "Darth Vader",
                "Heks",
                "Avatar"
            };

            var actual = queries.ListWizardNamesLinq(wizards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_of_wizard_names_grouped_by_creator_DSC_and_name_extension() 
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {
                "Darth Fiona",
                "Darth Shrek",
                "Sauron",
                "Troldmand1",
                "Troldmand2",
                "Troldkvinde1",
                "Troldkvinde2",
                "Darth Vader",
                "Heks",
                "Avatar"
            };

            var actual = queries.ListWizardNamesExtension(wizards);

            Assert.Equal(expected, actual);
        }

    }
}