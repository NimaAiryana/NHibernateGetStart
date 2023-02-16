using NHibernateGetStart.Domain.Aggregates.Common;

namespace NHibernateGetStart.Domain.Aggregates.UserAggergate
{
    public class User : AggregateRootBase
    {
        public User(Name name, int age)
        {
            Validate(name, age);

            Name = name;
            Age = age;
            _items = new();
        }

        public Name Name { get; private set; }
        public int Age { get; private set; }

        private readonly List<int> _items;
        public IReadOnlyCollection<int> Items => _items.AsReadOnly();

        public void Update(Name name, int age)
        {
            Validate(name, age);

            Name = name;
            Age = age;
        }

        private static void Validate(Name name, int age)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));

            if (age < 1) throw new ArgumentOutOfRangeException(nameof(age));
        }
    }
}
