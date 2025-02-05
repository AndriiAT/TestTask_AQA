using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace TestTask_AQA.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            StandardOneTimeSetUp();
            ExtendedOneTimeSetUp();
        }

        [SetUp]
        public virtual void SetUp()
        {
            StandardSetUp();
            ExtendedSetUp();
        }

        [TearDown]
        public virtual void TearDown()
        {
            StandardTearDown();
            ExtendedTearDown();

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine("Test failed: " + TestContext.CurrentContext.Test.Name);
            }
        }

        [OneTimeTearDown]
        public virtual void OneTimeTearDown()
        {
            StandardOneTimeTearDown();
            ExtendedOneTimeTearDown();
        }

        public virtual void ExtendedOneTimeSetUp() { }
        public virtual void StandardOneTimeSetUp() { }
        public virtual void ExtendedSetUp() { }
        public virtual void StandardSetUp() { }
        public virtual void ExtendedTearDown() { }
        public virtual void StandardTearDown() { }
        public virtual void ExtendedOneTimeTearDown() { }
        public virtual void StandardOneTimeTearDown() { }

        //Here could be  added methods like OnFailure() or CleanUp()
    }
}
