namespace TestAssignment322.Tests
{
    using NUnit.Framework;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            PowerClass powerClass = new PowerClass();

            Assert.That(8, Is.EqualTo(powerClass.Power(2, 3)));
        }
    }
}