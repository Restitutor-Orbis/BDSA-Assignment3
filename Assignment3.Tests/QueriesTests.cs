using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void only_return_names_of_wizards_invented_by_rowling_linq()
        {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Troldmand1", "Troldmand2"};

            var actual = queries.returnNamesInventedByRowlingLinq(wizards);

            Assert.Equal(expected, actual);
        }   

        [Fact]
        public void only_return_names_of_wizards_invented_by_rowling_extension() {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = new List<string> {"Troldmand1", "Troldmand2"};

            var actual = queries.returnNamesInventedByRowlingExtension(wizards);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void return_the_first_sithlord_linq() {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = 1977;

            var actual = queries.FindFirstSithLordLinq(wizards);

            Assert.Equal(expected,actual);
        }
                [Fact]
        public void return_the_first_sithlord_extension() {
            var queries = new Queries();
            var wizards = Wizard.Wizards.Value;
            var expected = 1977;

            var actual = queries.FindFirstSithLordExtension(wizards);

            Assert.Equal(expected,actual);
        }
    }
}