using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RegisterOfPeopleApp.Model
{
    [XmlRoot("Register")]
    public class Register
    {
        public Register()
        {
            People = new Person[0];
        }
        public Register(Person[] people)
        {
            People = people;
        }
        [XmlArray("People")]
        [XmlArrayItem("Person", Type = typeof(Person))]
        public Person[] People { get; set; }
    }
}
