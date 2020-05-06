using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class PremierLeagueTeams
    {
        List<PremierLeague> TeamsList = new List<PremierLeague>
        {
        new PremierLeague (club: "Arsenal", city: "London", founded: new DateTime(1886, 1 , 1), ground: "Emirates Stadium", champions: 13),
        new PremierLeague (club: "Chelsea", city: "London", founded: new DateTime(1905, 3, 10), ground: "Stamford Bridge", champions: 6),
        new PremierLeague (club: "Everton", city: "Liverpool", founded: new DateTime(1878, 1, 1), ground: "Goodison Park", champions: 9),
        new PremierLeague (club: "United", city: "Manchester", founded: new DateTime(1878, 1, 1), ground: "Old Trafford", champions: 20),
        new PremierLeague (club: "City", city: "Manchester", founded: new DateTime(1880, 1, 1), ground: "Etihad Stadium", champions: 6),
        new PremierLeague (club: "Leicester", city: "Leicester", founded: new DateTime(1884, 1, 1), ground: "King Power Stadium", champions: 1),
        new PremierLeague (club: "Liverpool", city: "Liverpool", founded: new DateTime(1892, 6, 3), ground: "Anfield", champions: 18),
        new PremierLeague (club: "Tottenham", city: "London", founded: new DateTime(1882, 9, 5), ground: "Tottenham Hotspur Stadium", champions: 2),
        new PremierLeague (club: "West_Ham", city: "London", founded: new DateTime(1895, 1, 1), ground: "London Stadium", champions: 0),
        new PremierLeague (club: "Wolverhampton", city: "Wolverhampton", founded: new DateTime(1877, 1, 1), ground: "Molineux Stadium", champions: 3),
        };
        
        public List<PremierLeague> ReturnTeamsList(int topTeams = 10)
        {
             return TeamsList.Take(topTeams).ToList();
        }
    }
}