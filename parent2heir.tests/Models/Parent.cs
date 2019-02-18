using System;

namespace parent2heir.tests.Models
{
    public class Parent
    {
        public string Str { get; set; }
        public int Int { get; set; }
        public CustomFieldValue Struct { get; set; }
        public CustomFieldReference Class { get; set; }

        public static bool operator ==(Parent p1, Parent p2)
        {
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                throw new NullReferenceException();
            return p1.Int == p2.Int
                   && p1.Str == p2.Str
                   && p1.Struct == p2.Struct
                   && p1.Class == p2.Class;
        }


        public static bool operator !=(Parent p1, Parent p2)
        {
            return !(p1 == p2);
        }
    }
}