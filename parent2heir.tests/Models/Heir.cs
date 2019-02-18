namespace parent2heir.tests.Models
{
    public class Heir : Parent
    {
        public bool AdditionalProperty => string.IsNullOrEmpty(Str);
    }
}