using System;

namespace SerializationTutor.Entities
{
    [UserInfo(67)]
    public class Person
    {
        public string name;
        public string surname;
        [NonSerialized]
        public int age;
        public long phone;
        public Address address;
    }
}
