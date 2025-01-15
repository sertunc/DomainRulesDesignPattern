namespace DomainRulesDesignPattern.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public BookTitle Title { get; set; }
    }
}