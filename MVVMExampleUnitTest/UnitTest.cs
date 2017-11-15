
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVVMUnitTesting
{
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void TestProperties()
        {//check to see if properties getters setters work;
            const String expected = new Random().Next();
            const Int32 expectedInt = new Random().Next();


            var PropName = new Person() { Name = expected };
            var PropAge = new Person() { Age = expected };
            var PropProffesion = new Person() { Proffesions = expected };
            var PropID = new Person() { ID = expected };

            Assert.Equal(expected, PropName.Name);
            Assert.Equal(expectedInt, PropAge.Age);
            Assert.Equal(expected, PropProffesion.Proffesions);
            Assert.Equal(expectedInt, PropID.ID);
        }
        public void TestAdd()
        {
            //Arrange
            Person person_ = new Person(aidi_, NameX, AgeX, ProfessionX);
            var aidi_ = aidi_++;
            var NameX = "Jordan";
            var AgeX = 22;
            var ProfessionX = "Programmer";
            String personStr = person_.Sentence;

            //Act
            var personList_.Add(person_);
            var peopleFound_.Add(personStr);

            //Assert
            Assert.IsNotNull(person_);
            Assert.IsNotNull(peopleFound_);
        }

        public void TestDelete()
        {
            //Arrange
            Person person_ = new Person(aidi_, NameX, AgeX, ProfessionX);
            var aidi_ = aidi_++;
            var NameX = "Jordan";
            var AgeX = 22;
            var ProfessionX = "Programmer";
            String personStr = person_.Sentence;

            //Act
            var personList_.Remove(person_);
            var peopleFound_.Remove(personStr);

            //Assert
            Assert.IsNull(person_);
            Assert.IsNull(peopleFound_);
        }

        public void TestEdit()
        {
            //Arrange
            Person person_ = new Person(aidi_, NameX, AgeX, ProfessionX);
            var aidi_ = aidi_++;
            var NameX = "Jordan";
            var AgeX = 22;
            var ProfessionX = "Programmer";
            String personStr = person_.Sentence;

            //Act
            var personList_.Remove(person_);
            var peopleFound_.Remove(personStr);

            //Assert
            Assert.AreNotEqual(person_, newPerson_);
            Assert.IsNull(peopleFound_);
        }
    }
}
