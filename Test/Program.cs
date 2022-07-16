using System;

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            Adress program = new Adress();
            program.Index = "225710";
            Console.WriteLine(program.Index);
            program.Country = "Belarus";
            Console.WriteLine(program.Country);
            program.City = "Pinsk";
            Console.WriteLine(program.City);
            program.Street = "Brest street";
            Console.WriteLine(program.Street);
            program.House = "95";
            Console.WriteLine(program.House);
            program.Apartment = "24";
            Console.WriteLine(program.Apartment);
            Console.ReadKey();
        }
    }
    class Adress
    {
        string index;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
            
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
            
        }
        string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
           
        }
        string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
           
        }
        string house;
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
            
        }
        string apartment;
        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
           
        }
    }
}
