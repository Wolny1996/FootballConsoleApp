using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class PremierLeagueCoaches
    {
        List<Coach> CoachesList = new List<Coach>
        {
        new Coach (name: "Mikel", surname: "Arteta", nationality: "Spain", currentTeam: "Arsenal"),
        new Coach (name: "Frank", surname: "Lampard", nationality: "England", currentTeam: "Chelsea"),
        new Coach (name: "Carlo", surname: "Ancelotti", nationality: "Italy", currentTeam: "Everton"),
        new Coach (name: "Ole Gunnar", surname: "Solskjær", nationality: "Norway", currentTeam: "United"),
        new Coach (name: "Josep", surname: "Guardiola", nationality: "Spain", currentTeam: "City"),
        new Coach (name: "Brendan", surname: "Rodgers", nationality: "Northern_Ireland", currentTeam: "Leicester"),
        new Coach (name: "Jurgen", surname: "Klopp", nationality: "Germany", currentTeam: "Liverpool"),
        new Coach (name: "José", surname: "Mourinho", nationality: "Portugal", currentTeam: "Tottenham"),
        new Coach (name: "David", surname: "Moyes", nationality: "Scotland", currentTeam: "West_Ham"),
        new Coach (name: "Nuno Espirito", surname: "Santo", nationality: "Portugal", currentTeam: "Wolverhampton"),
        };

        public List<Coach> ReturnCoachesList(int topCoach = 10)
        {
            return CoachesList.Take(topCoach).ToList();
        }
    }
}