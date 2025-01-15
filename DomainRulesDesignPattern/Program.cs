using DomainRulesDesignPattern.Domain;
using DomainRulesDesignPattern.DomainRules;

var rules = new List<IBusinessRule<BookTitle>>
        {
            new NotNullOrEmptyRule(),
            new TitleCaseRule()
        };

var compositeRule = new CompositeRule<BookTitle>(rules);

var invalidTitle = new BookTitle("  ");
var validTitle = new BookTitle("the great gatsby");

Console.WriteLine($"Invalid Title Before: {invalidTitle.Title}");
var correctedInvalidTitle = compositeRule.Apply(invalidTitle);
Console.WriteLine($"Invalid Title After: {correctedInvalidTitle.Title}");

Console.WriteLine($"Valid Title Before: {validTitle.Title}");
var correctedValidTitle = compositeRule.Apply(validTitle);
Console.WriteLine($"Valid Title After: {correctedValidTitle.Title}");

Console.ReadLine();