using NHibernateGetStart.Domain.Aggregates.Common;

namespace NHibernateGetStart.Domain.Aggregates.ItemAggregate
{
    public class Item : AggregateRootBase
    {
        public Item(string title)
        {
            Validate(title);

            Title = title;
        }

        public string Title { get; private set; }

        public void Validate(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
        }
    }
}
