using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class PremierLeague
    {
        private string club;
        private string city;
        private DateTime founded;
        private int age;
        private string ground;
        private int champions;

        public string Club
        {
            get => club;
            set
            {
                if (club == string.Empty)
                {
                    Console.WriteLine("club error");
                }
                else
                {
                    club = value;
                }
            }
        }
        public string City
        {
            get => city;
            set
            {
                if (city == string.Empty)
                {
                    Console.WriteLine("city error");
                }
                else
                {
                    city = value;
                }
            }
        }
        public DateTime Founded
        {
            get => founded;
            set
            {
                if (founded.Year < 0)
                {
                    Console.WriteLine("club error");
                }
                else
                {
                    founded = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Founded.Year;
            }
            set
            {
                age = value;
            }
        }
        public string Ground
        {
            get => ground;
            set
            {
                if (ground == string.Empty)
                {
                    Console.WriteLine("ground error");
                }
                else
                {
                    ground = value;
                }
            }
        }
        public int Champions
        {
            get => champions;
            set
            {
                if (champions < 0)
                {
                    Console.WriteLine("champions error");
                }
                else
                {
                    champions = value;
                }
            }
        }
        public PremierLeague(string club, string city, DateTime founded, string ground, int champions)
        {
            Club = club; City = city; Founded = founded; Ground = ground; Champions = champions;
        }
    }

            //    if (!string.IsNullOrEmpty(value))
            //{
            //    name = value;
            //}
            //else
            //{
            //    name = "Unknown";
            //}

}