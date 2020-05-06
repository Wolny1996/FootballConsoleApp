using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football;

namespace Football
{
    public interface IPremierLeagueTeamsDataProvider
    {
        PremierLeagueTeams ReturnTeamsList();
    }
    public interface IPremierLeagueCoachesDataProvider
    {
        PremierLeagueCoaches ReturnCoachesList();
    }
}
