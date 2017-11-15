using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMUnitTestingAirPlane
{
    [TestClass]
    public class UnitTestAirPlane
    { 
        [TestMethod]
        public void TestProperties()
        {//check to see if properties getters setters work;
            const String expected = new Random().Next();
            const Int32 expectedInt = new Random().Next();


            var PropCompanyName = new AirPlane() { CompanyNameModel = expected };
            var PropTypeOfPlane = new AirPlane() { TypeOfPlaneModel = expected };
            var PropNumOfPlanes = new AirPlane() { NumOfPlanesModel = expected };
            var PropiD = new AirPlane() { iD = expected };

            Assert.Equal(expected, PropCompanyName.CompanyNameModel);
            Assert.Equal(expected, PropTypeOfPlane.TypeOfPlanesModel);
            Assert.Equal(expectedInt, PropNumOfPlanes.NumOfPlanesModel);
            Assert.Equal(expectedInt, PropiD.iD);

        }
    }


        public void TestAdd()
        {
            //Arrange
            AirPlane airPlane_ = new AirPlane(aidi_, CompanyName, NumOfPlanes, TypeOfPlanes);
            var aidi_ = aidi_++;
            var CompanyName = "American Airlines";
            var NumOfPlanes = 5;
            var TypeOfPlanes = "CargoPlane";
            String AirPlaneStr = airPlane_.Sentence;

            //Act
            var AirPlaneList_.Add(airPlane_);
            var AirPlaneFound_.Add(AirPlaneStr);

            //Assert
            Assert.IsNotNull(AirPlaneList_);
            Assert.IsNotNull(AirPlaneFound_);
        }

        public void TestDelete()
        {
            //Arrange
            AirPlane airPlane_ = new AirPlane(aidi_, CompanyName, NumOfPlanes, TypeOfPlanes);
            var aidi_ = aidi_++;
            var CompanyName = "American Airlines";
            var NumOfPlanes = 5;
            var TypeOfPlanes = "CargoPlane";
            String AirPlaneStr = airPlane_.Sentence;

            //Act
            var AirPlaneList_.Remove(airPlane_);
            var AirPlaneFound_.Remove(AirPlaneStr);

            //Assert
            Assert.IsNull(AirPlaneList_);
            Assert.IsNull(AirPlaneFound_);
        }

        public void TestEdit()
        {
            //Arrange
            AirPlane airPlane_ = new AirPlane(aidi_, CompanyName, NumOfPlanes, TypeOfPlanes);
            var aidi_ = aidi_++;
            var CompanyName = "American Airlines";
            var NumOfPlanes = 5;
            var TypeOfPlanes = "CargoPlane";
            String AirPlaneStr = airPlane_.Sentence;

            //Act
            var personList_.Remove(person_);
            var peopleFound_.Remove(personStr);

            //Assert
            Assert.AreNotEqual(person_, newPerson_);
            Assert.IsNull(peopleFound_);
        }
        }
    }
}
