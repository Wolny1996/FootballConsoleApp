using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class Human
    {
        private string name;
        private string surname;
        private string nationality;

        public string Name
        {
            get => name;
            set
            {
                if (name == string.Empty)
                {
                    Console.WriteLine("human name error");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (surname == string.Empty)
                {
                    Console.WriteLine("human surname error");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public string Nationality
        {
            get => nationality;
            set
            {
                if (nationality == string.Empty)
                {
                    Console.WriteLine("human nationality error");
                }
                else
                {
                    nationality = value;
                }
            }
        }
        public Human(string name, string surname, string nationality)
        {
            Name = name; Surname = surname; Nationality = nationality; 
        }
    }
}
