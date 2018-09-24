using SlowballGenerator.Code;
using System;
using System.Collections.Generic;

namespace SlowballGenerator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            int numPlayers = 20;
            int nbrOfTeams = 20 / 2;
            int rounds = 3;
            List<Player> players = new List<Player>();
            for (int i = 1; i <= numPlayers; i++)
            {
                Player player = new Player
                {
                    Name = "Person " + i.ToString()
                };
                players.Add(player);
            }
            Tournament tournament = new Tournament(rounds);

            ExtensionMethods.Shuffle(players);
            for (int i = 0; i < rounds; i++)
            {
                TournamentRound round = new TournamentRound("Round : " + (i+1).ToString());
                List<Team> teams = TeamGenerator.GenerateTeams(players, nbrOfTeams);
                round.Teams = teams;
                round.Matches = MatchGenerator.GenerateMatches(teams, teams.Count / 2);
                tournament.Rounds.Add(round);
            }

            ASPxListBox1.DataSource = tournament.Rounds[0].Matches;
            ASPxListBox1.TextField = "Name";
            ASPxListBox1.DataBind();

            ASPxListBox2.DataSource = tournament.Rounds[1].Matches;
            ASPxListBox2.TextField = "Name";
            ASPxListBox2.DataBind();

            ASPxListBox3.DataSource = tournament.Rounds[2].Matches;
            ASPxListBox3.TextField = "Name";
            ASPxListBox3.DataBind();
        }
    }
}