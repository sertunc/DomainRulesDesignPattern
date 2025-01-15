namespace DomainRulesDesignPattern.DomainRules
{
    public class CompositeRule<T> : IBusinessRule<T>
    {
        private readonly IEnumerable<IBusinessRule<T>> _rules;

        public CompositeRule(IEnumerable<IBusinessRule<T>> rules)
        {
            _rules = rules;
        }

        public bool IsSatisfiedBy(T input)
        {
            return _rules.All(rule => rule.IsSatisfiedBy(input));
        }

        public T Apply(T input)
        {
            return _rules.Aggregate(input, (current, rule) => rule.Apply(current));
        }
    }
}