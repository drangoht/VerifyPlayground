namespace VerifyPlayground.Core
{
    public class Person
    {
        public Guid Id { get; init; }
        public string LastName { get; init; }
        public string FirstName { get; private set; }  


        public int BirthYear { get; init; }

        public Person(Guid id, string firstName, string lastName, int birthYear)
        {
            if(id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        public int GetAge()
        {
            return DateTime.UtcNow.Year-BirthYear;
        }

        public void UpdateFirstname(string firstName) => FirstName=firstName;

    }
}
