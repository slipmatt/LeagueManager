using LeagueManager.Data;
using System;
using System.Collections.Generic;

namespace LeagueManager.Tests.Mock.Database.MockData
{
    public class TeamsMockData : BaseMock
    {
        public TeamsMockData()
        {
            PopulateTeams();
        }

        private void PopulateTeams()
        {
            var teams = new List<Team>
            {
                 new Team
                {
                    TeamId = 1,
                    TeamName="Brazil"
                },
                new Team
                {
                    TeamId = 2,
                    TeamName="China"
                }
            };
            MockContext.Setup(i => i.Set<Team>()).Returns(MockHelper.GetMockSet(teams).Object);
            MockContext.SetupGet(i => i.Teams).Returns(() => MockHelper.GetMockSet(teams).Object);
        }       
    }
}
