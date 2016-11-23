using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueManager.Classes;
using LeagueManager.Data;
using LeagueManager.Tests.Mock.Database.MockData;
using NUnit.Framework;
using UnitOfWork;

namespace LeagueManager.Tests
{
    [TestFixture]
    public class TeamTests
    {
        Moq.Mock<LeagueManagerEntities> _context;

        #region Setup / Teardown
        [OneTimeSetUp]
        public void Init()
        {
            _context = new Mock.Database.MockData.TeamsMockData().MockContext;
        }

        [OneTimeTearDown]
        public void Close()
        {
            
        }
        #endregion

        [TestCase()]
        public void Given_NoInput_ShouldGetAllTeams()
        {
            //Arrange
            var teams = new TeamClass(new Uow(_context.Object));
            var expected = 2;
            //Act
            var actual = teams.GetAllTeams().Count();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
