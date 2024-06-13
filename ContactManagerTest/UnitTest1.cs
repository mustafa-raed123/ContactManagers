using Xunit;
using System.Runtime.CompilerServices;
using ContactManagers;
using System.Xml.Linq;





namespace ContactManagerTest
{
    public class UnitTest1
    {

        [Fact]
        public void AddContact()
        {
            Program.Contacts.Clear();
            //Arrange
            string name1 = "Ahmed";
            List<string> list = Program.Contacts;
            //Act
            List<string> result = Program.AddContact(name1);  // {Ahmed}

            bool Contains = list.Contains("Ahmed");
            //Assert
            Assert.Equal(true, Contains);

        }


        [Fact]
        public void duplicateAddContact()
        {
            Program.Contacts.Clear();

            //Arragnge
            string name1 = "mohammed";
            string name2 = "Ali";
            List<string> list = Program.Contacts;
            //Act
            List<string> result = Program.AddContact(name1);  // {mohammed}
            result = Program.AddContact(name2);   // {mohammed,Ali}
            result = Program.AddContact(name2);   // {mohammed,Ali}

            int s = result.Count;
            //Assert
            Assert.Equal(2, s);
        }

        [Fact]
        public void RemoveContact()
        {
            Program.Contacts.Clear();

            //arrange
            string name1 = "mohammed";
            string name2 = "Ali";
            List<string> list = new List<string>();
            //Act
            List<string> result = Program.AddContact(name1);  // {,mohammed}
            result = Program.AddContact(name2);   // {mohammed,Ali}
            result = Program.RemoveContact(name1);// {Ali}

            bool name = result.Contains("mohammed");
            //Assert
            Assert.Equal(false, name);
        }
        [Fact]
        public void ViewAllContacts()
        {
            Program.Contacts.Clear();

            //Arrange
            string name1 = "mohammed";
            string name2 = "Ali";
            //Act
            List<string> result = Program.AddContact(name1);  // {,mohammed}
            result = Program.AddContact(name2);    // {mohammed,Ali}
            List<string> list = Program.Contacts;
            result = Program.ViewAllContacts(list);          // {mohammed,Ali}
            //Assert
            Assert.Equal(2, result.Count);


        }
    }

}