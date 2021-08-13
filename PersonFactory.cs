using System;
using System.Collections.Generic;
using System.Text;

namespace Search
{
    public class PersonFactory
    {
        public IEnumerable<Person> Create(string[] firstNames, string[] lastNames)
        {
            int count = 0;

            var factory = new PersonFactory();

            foreach (var lastName in lastNames)
            {
                if (count > 15000) break;
                var firstName = firstNames[count % firstNames.Length];
                var middleInitialIndex = Math.Abs(count - 17) % firstNames.Length;
                var middleName = firstNames[middleInitialIndex];
                yield return new Person(++count, firstName, middleName, lastName);
            }
        }
    }
}
