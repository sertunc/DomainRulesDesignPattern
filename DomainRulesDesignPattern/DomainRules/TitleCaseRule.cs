using DomainRulesDesignPattern.Domain;

namespace DomainRulesDesignPattern.DomainRules
{
    public class TitleCaseRule : IBusinessRule<BookTitle>
    {
        public bool IsSatisfiedBy(BookTitle input)
        {
            return input.Title == System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.Title.ToLower());
        }

        public BookTitle Apply(BookTitle input)
        {
            if (!IsSatisfiedBy(input))
            {
                return new BookTitle(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.Title.ToLower()));
            }
            return input;
        }
    }
}