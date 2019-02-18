namespace parent2heir.tests.Models
{
    public class CustomFieldReference
    {
        public int Int { get; set; }
        public string Str { get; set; }

        public static bool operator ==(CustomFieldReference p1, CustomFieldReference p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
                return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Str == p2.Str
                   && p1.Int == p2.Int;
        }

        public static bool operator !=(CustomFieldReference p1, CustomFieldReference p2)
        {
            return !(p1 == p2);
        }
    }
}