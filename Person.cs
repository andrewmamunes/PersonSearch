namespace Search
{
    public class Person
    {
        public Person(int id, string firstName, string middleName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            SearchTerms = new[] { firstName, middleName, lastName };
        }

        public int Id { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string[] SearchTerms { get; }
    }
}
