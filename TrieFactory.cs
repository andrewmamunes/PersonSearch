using Gma.DataStructures.StringSearch;
using System.Collections.Generic;

namespace Search
{
    public class TrieFactory
    {
        public UkkonenTrie<int> MakeTrie(ICollection<Document> documents)
        {
            var trie = new UkkonenTrie<int>(3);

            foreach (var doc in documents)
            {
                trie.Add(doc.Term.Normalize(), doc.Id);
            }

            return trie;
        }
    }
}
