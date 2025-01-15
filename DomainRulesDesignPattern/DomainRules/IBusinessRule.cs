namespace DomainRulesDesignPattern.DomainRules
{
    public interface IBusinessRule<T>
    {
        bool IsSatisfiedBy(T input);

        T Apply(T input);
    }
}