namespace parent2heir.tests.BaseTests
{
    public abstract class BaseConvertTests<TParent, THeir> where THeir : TParent
    {
        public delegate THeir ConvertFunc<TParent, THeir>(TParent parent);

        public ConvertFunc<TParent, THeir> Convert;

        protected BaseConvertTests(ConvertFunc<TParent, THeir> convert)
        {
            Convert = convert;
        }
    }
}