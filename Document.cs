namespace Search
{
    public class Document
    {
        public string Term { get; set; }
        public string Type { get; set; }
        public int ParentId { get; set; }
        public int Id { get; set; }
        public Document(string term, string type, int parentId, int id)
        {
            Term = term;
            Type = type;
            ParentId = parentId;
            Id = id;
        }

        public override string ToString()
        {
            return $"Term : {Term} - Type : {Type} - PersonId : {ParentId}";
        }
    }
}
