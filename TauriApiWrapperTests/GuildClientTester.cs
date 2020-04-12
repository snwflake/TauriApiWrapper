using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class GuildClientTester
    {
        [TestMethod]
        public void GetGuildRoster()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildRoster> returnData = client.GetGuildRoster("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }

        [TestMethod]
        public void GetGuildStats()
        {
            using (GuildClient client = new GuildClient(TestingCredentials.ApiKey, TestingCredentials.Secret))
            {
                ApiResponse<GuildStats> returnData = client.GetGuildStats("Muzykanci z Gruzji");
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }
    }
}