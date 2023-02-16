using NHibernateGetStart.Domain.Aggregates.Common;

namespace NHibernateGetStart.Domain.Aggregates.UserAggergate
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            Validate(firstName, lastName);

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private static void Validate(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentNullException(nameof(lastName));
        }
    }
}
