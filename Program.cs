using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Gma.DataStructures.StringSearch.UkkonenTrie<HashSet<int>>(3);

            var namesWithTypes = File.ReadAllLines("Data\\Names.txt");

            var allDocuments = new List<Document>(namesWithTypes.Length);

            int count = 0;

            foreach (var name in namesWithTypes)
            {
                var split = name.Split(',');
                allDocuments.Add(new Document(split[1].Normalize(), split[2].Normalize(), int.Parse(split[0]), ++count));
            }

            var documentDictionary = allDocuments.ToDictionary(doc => doc.Id, doc => doc);

            var searchIndex = new TrieFactory().MakeTrie(allDocuments);

            Console.Write($"Insert a search query to begin:");
            var input = Console.ReadLine();

            while (input != "q")
            {
                var matchedDocumentIds = searchIndex.Retrieve(input.Normalize());
                Console.WriteLine($"Search term {input} matched {matchedDocumentIds.Count()} documents: ");
                foreach (var docId in matchedDocumentIds) 
                {
                    Console.WriteLine(documentDictionary[docId].ToString());
                }
                Console.Write("Input another search query : ");
                input = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
