using parent2heir.jsonNet.Extensions;
using parent2heir.tests.BaseTests;
using parent2heir.tests.Models;

namespace parent2heir.tests
{
    public class BsonConverterTests : BaseParentHeirTests
    {
        public BsonConverterTests() : base(p => p.ToHeir<Parent, Heir>())
        {
        }
    }
}