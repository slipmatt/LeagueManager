using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitOfWork;

namespace Leaguemanager.Tests
{
    [TestFixture]
    public class EventsTests
    {
        private IUow _uow { get; set; }
        #region Setup / Teardown
        [TestFixtureSetUp]
        public void Init()
        {
            
        }

        [TestFixtureTearDown]
        public void Close()
        {
            
        }
        #endregion


    }
}
