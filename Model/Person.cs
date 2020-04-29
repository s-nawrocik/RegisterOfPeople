using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace RegisterOfPeopleApp.Model
{
    public class Person
    {
        public Person()
        {
            DateOfBirth = new DateTime(2000,1,1);
        }
        [XmlAttribute("FirstName")]
        public string FirstName { get; set; }

        [XmlAttribute("LastName")]
        public string LastName { get; set; }

        [XmlAttribute("StreetName")]
        public string StreetName { get; set; }

        [XmlAttribute("HouseNumber")]
        public string HouseNumber { get; set; }

        [XmlAttribute("ApartmentNumber")]
        public string ApartmentNumber { get; set; }

        [XmlAttribute("PostalCode")]
        public string PostalCode { get; set; }

        [XmlAttribute("Town")]
        public string Town { get; set; }

        [XmlAttribute("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [XmlAttribute("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }
    }
}
