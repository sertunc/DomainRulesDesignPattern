using DomainRulesDesignPattern.Domain;

namespace DomainRulesDesignPattern.DomainRules
{
    public class NotNullOrEmptyRule : IBusinessRule<BookTitle>
    {
        public bool IsSatisfiedBy(BookTitle input)
        {
            return !string.IsNullOrEmpty(input.Title);
        }

        public BookTitle Apply(BookTitle input)
        {
            if (!IsSatisfiedBy(input))
            {
                return new BookTitle("Default Title");
            }

            return input;
        }
    }
}