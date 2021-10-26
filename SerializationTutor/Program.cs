using SerializationTutor.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                surname = "Ermeeva",
                name = "Rufina",
                age = 40,
                phone = 79278096745,
                address = new Address()
                {
                    country = "Russia",
                    town = "Kazan",
                    street = "Pushkina",
                    house = 30,
                    flat = 167
                }

            };

            List<Person> people = new List<Person>()
            {
                new Person()
                {
                    surname = "Ermeeva",
                    name = "Rufina",
                    age = 40,
                    phone = 79278096745,
                    address = new Address()
                    {
                        country = "Russia",
                        town = "Kazan",
                        street = "Pushkina",
                        house = 30,
                        flat = 167
                    }
                },
                new Person()
                {
                    surname = "Daniel",
                    name = "Korshunov",
                    age = 78,
                    phone = 79278096745,
                    address = new Address()
                    {
                        country = "Russia",
                        town = "Kazan",
                        street = "Prosekt Pobedi",
                        house = 17,
                        flat = 1
                    }
                }
            };


            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(FileStream file = new FileStream("serialized1.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, person);
            }

            Person newPerson;
            using (FileStream file = new FileStream("serialized1.txt", FileMode.OpenOrCreate))
            {
                newPerson = (Person)binaryFormatter.Deserialize(file);
            }



            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream file = new FileStream("serialized2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, people);
            }

        }
    }

    class UserInfoAttribute : Attribute
    {
        public int Age { get; set; }

        public UserInfoAttribute(int age)
        {
            Age = age;
        }
    }

}
