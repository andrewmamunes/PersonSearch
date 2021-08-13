using System.Collections.Generic;
using System.Linq;

namespace Search
{
    public class SearchTermDictionary
    {
        public Dictionary<string, HashSet<int>> TermsToPeople;
        public SearchTermDictionary(IEnumerable<Person> people)
        {
            TermsToPeople = new Dictionary<string, HashSet<int>>();
            foreach (var person in people)
            {
                foreach (var searchTerm in person.SearchTerms)
                {
                    if (TermsToPeople.TryGetValue(searchTerm, out var personIds))
                    {
                        if (!personIds.Contains(person.Id))
                        {
                            personIds.Add(person.Id);
                        }
                    }
                    else {
                        TermsToPeople[searchTerm] = new List<int> { person.Id }.ToHashSet();
                    }
                }
            }
        }


    }
}
