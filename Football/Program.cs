using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PremierLeague> TeamsList = ReturnTeams();
            List<Coach> CoachesList = ReturnCoaches();
            bool canCoutinue;
            do
            {
                Console.WriteLine("Select a team");
                string selectedTeam = Console.ReadLine();
                var i = 0;
                foreach (var team in TeamsList)
                {
                    i++;
                    if (selectedTeam == team.Club)
                    {
                        ShowTeam(team);
                        AssignACoach(CoachesList, selectedTeam);
                        break;
                    }
                    Console.WriteLine($"pętla wykonala sie {i} razy");
                }
                canCoutinue = UserDecision();
            } while (canCoutinue);
        }

        private static void ShowTeam(PremierLeague team)
        {
            //Console.WriteLine($"Club:{team.Club}\nCity:{team.City}...");
            Console.WriteLine("Club:{0}\nCity:{1}\nFounded:{2}\nAge:{3}\nGround:{4}\nChampions:{5}",
                team.Club, team.City, team.Founded, team.Age, team.Ground, team.Champions);
        }

        private static bool UserDecision()
        {
            bool canCoutinue;
            Console.WriteLine("If you want to continue enter Y, if not then N");
            string userDecision = Console.ReadLine();

            if (userDecision == "Y")
            {
                canCoutinue = true;
            }
            else if (userDecision == "N")
            {
                canCoutinue = false;
            }
            else { canCoutinue = false; }

            return canCoutinue;
        }

        private static void AssignACoach(List<Coach> CoachesList, string selectedTeam)
        {
            var coach = CoachesList.FirstOrDefault(c => selectedTeam == c.CurrentTeam);
            if (coach == null)
            {
                Console.WriteLine("Błąd");
                return;
            }
            ShowCoach(coach);
            Console.WriteLine($"Liczba trenerów dostaczana na liście {CoachesList.Count}");
        }

        private static void ShowCoach(Coach coach)
        {
            Console.WriteLine("Coach:{0} {1}\nNationality:{2}",
                coach.Name, coach.Surname, coach.Nationality);
        }

        private static List<Coach> ReturnCoaches()
        {
            PremierLeagueCoaches coaches = new PremierLeagueCoaches();
            List<Coach> CoachesList = coaches.ReturnCoachesList();
            return CoachesList;
        }

        private static List<PremierLeague> ReturnTeams()
        {
            PremierLeagueTeams teams = new PremierLeagueTeams();
            List<PremierLeague> TeamsList = teams.ReturnTeamsList();
            return TeamsList;
        }
    }
}