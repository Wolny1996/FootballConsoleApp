using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Coach : Human
    {
        private string currentTeam;

        public string CurrentTeam
        {
            get => currentTeam;
            set
            {
                if (currentTeam == string.Empty)
                {
                    Console.WriteLine("current team error");
                }
                else
                {
                    currentTeam = value;
                }
            }
        }
        public Coach (string name, string surname, string nationality, string currentTeam) 
            : base(name, surname, nationality)
        {
            CurrentTeam = currentTeam;
        }
    }
}
