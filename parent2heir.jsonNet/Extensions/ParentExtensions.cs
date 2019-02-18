namespace parent2heir.jsonNet.Extensions
{
    public static class ParentExtensions
    {
        public static void ToHeir<TParent, THeir>(this TParent parent, out THeir heir) where THeir : TParent
        {
            heir = ParentConverter.ToHeir<TParent, THeir>(parent);
        }

        public static THeir ToHeir<TParent, THeir>(this TParent parent) where THeir : TParent
        {
            return ParentConverter.ToHeir<TParent, THeir>(parent);
        }
    }
}