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
            ExtensionMethods.Shuffle(players);
            Tournament tournament = new Tournament(rounds);


            for (int i = 0; i < rounds; i++)
            {
                TournamentRound round = new TournamentRound("Round : " + (i+1).ToString());
                int partnerRandomStart = ThreadSafeRandom.ThisThreadsRandom.Next(0, numPlayers - 1);
                int partnerRandomIntervall = ThreadSafeRandom.ThisThreadsRandom.Next(1, numPlayers - 1);
                List<Team> teams = TeamGenerator.GenerateTeams(partnerRandomStart, partnerRandomIntervall, players, nbrOfTeams);
                round.Teams = teams;
                tournament.Rounds.Add(round);
            }


            ASPxListBox1.DataSource = tournament.Rounds[0].Teams;
            ASPxListBox1.TextField = "Name";
            ASPxListBox1.DataBind();

            //ASPxListBox2.DataSource = tournament.Teams[1];
            //ASPxListBox2.TextField = "Name";
            //ASPxListBox2.DataBind();

            //ASPxListBox3.DataSource = tournament.Teams[2];
            //ASPxListBox3.TextField = "Name";
            //ASPxListBox3.DataBind();
        }
    }
}