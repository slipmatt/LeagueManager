using Moq;
using UnitOfWork;

namespace LeagueManager.Tests.Mock.Database
{
    public class BaseMock
    {
        public Mock<LeagueManager.Data.LeagueManagerEntities> MockContext { get; set; }

        public BaseMock()
        {
            MockContext = new Mock<LeagueManager.Data.LeagueManagerEntities>();

            MockContext.As<IUow>().CallBase = false;
        }
    }
}
