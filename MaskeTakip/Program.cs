using Bussiness.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person
        {
            FirstName = "DENİZ",
            LastName = "ÖZVEREN",
            DateOfBirthYear = 2002,
            NationalIdentity = 6789
        };
        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person);

    }
}


