using NUnit.Framework;
using parent2heir.jsonNet.Extensions;
using parent2heir.tests.Models;

namespace parent2heir.tests.BaseTests
{
    public abstract class BaseParentHeirTests : BaseConvertTests<Parent, Heir>
    {
        public BaseParentHeirTests(ConvertFunc<Parent, Heir> convert) : base(convert)
        {
        }

        [Test]
        public void EmptyObjects()
        {
            var parent = new Parent();
            var heirResult = new Heir();
            parent.ToHeir(out heirResult);
            var heirToBase = (Parent) heirResult;
            Assert.True(parent == heirToBase);
        }

        [Test]
        public void SimpleObjects()
        {
            var parent = new Parent
            {
                Int = 656,
                Str = "someString"
            };
            var heirResult = new Heir();
            parent.ToHeir(out heirResult);
            var heirToBase = (Parent) heirResult;
            Assert.True(parent == heirToBase);
        }

        [Test]
        public void CompositObjects()
        {
            var parent = new Parent
            {
                Int = 656,
                Str = "someString",
                Class = new CustomFieldReference
                {
                    Int = 322,
                    Str = "someString2"
                },
                Struct = new CustomFieldValue
                {
                    Int = 5333,
                    Str = "someString3"
                }
            };
            var heirResult = new Heir();
            parent.ToHeir(out heirResult);
            var heirToBase = (Parent) heirResult;
            Assert.True(parent == heirToBase);
        }
    }
}