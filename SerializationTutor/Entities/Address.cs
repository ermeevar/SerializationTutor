using System;

namespace SerializationTutor.Entities
{
    [Serializable]
    public class Address
    {
        public string country;
        public string town;
        public string street;
        public int house;
        public int flat;
    }
}