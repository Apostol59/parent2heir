namespace parent2heir.tests.Models
{
    public struct CustomFieldValue
    {
        public int Int { get; set; }
        public string Str { get; set; }

        public static bool operator ==(CustomFieldValue p1, CustomFieldValue p2)
        {
            return p1.Str == p2.Str
                   && p1.Int == p2.Int;
        }

        public static bool operator !=(CustomFieldValue p1, CustomFieldValue p2)
        {
            return !(p1 == p2);
        }
    }
}