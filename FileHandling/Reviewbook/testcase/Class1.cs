using NUnit.Framework;
using Reviewbook;

namespace testcase
{
    [TestFixture]
    public class AddContactTests
    {
        [SetUp]
        public void Setup()
        {
            Program.addressBook.Clear();
        }

        [Test]
        public void AddContact_ShouldAddContactUnderCorrectKey()
        {
        
            var contact = new Contacts(
                "Ayush",
                "Singh",
                "MG Road",
                "Bangalore",
                "Karnataka",
                "560001"
            );

    
            bool result = Program.AddContact(contact);

            Assert.That(result, Is.True);
            Assert.That(Program.addressBook.ContainsKey('A'), Is.True);
            Assert.That(Program.addressBook['A'].Count, Is.EqualTo(1));
            Assert.That(Program.addressBook['A'][0].FirstName, Is.EqualTo("Ayush"));
        }
    }
}
