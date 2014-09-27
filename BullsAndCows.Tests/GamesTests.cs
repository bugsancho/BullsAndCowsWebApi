
namespace BullsAndCows.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Web.Http;
    using System.Linq;
    using System.Web.Http.Routing;
    using System.Net.Http;
    using BullsAndCows.WebApi.Models;
    using Telerik.JustMock;
    using BullsAndCows.Data.Repositories;
    using BullsAndCows.Models;
    using BullsAndCows.Data;
    using BullsAndCows.WebApi.Controllers;
    using System.Threading;
    using System.Collections.Generic;

    [TestClass]
    //public class GamesTests
    //{
    //    [TestMethod]
    //    public void GetAll_WhenScoresInDb_ShouldBeOnly10()
    //    {
    //        Player[] articles = this.GenerateValidTestGames(20);
            
    //        var repo = Mock.Create<IRepository<Player>>();
    //        Mock.Arrange(() => repo.All())
    //            .Returns(() => articles.AsQueryable());

    //        var data = Mock.Create<IBullsAndCowsData>();

    //        Mock.Arrange(() => data.Players)
    //            .Returns(() => repo);

    //        var controller = new GamesController(data);
    //        this.SetupController(controller);

    //        var actionResult = controller.GetAll();    

    //        var response = actionResult.ExecuteAsync(CancellationToken.None).Result;

    //        var resultCount = response.Content.ReadAsAsync<IEnumerable<ScoreRankModel>>().Result.Count();

    //        Assert.AreEqual(10, resultCount);
    //    }

    //    private Player[] GenerateValidTestGames(int count)
    //    {   
    //        Player[] scores = new Player[count];

    //        for (int i = 0; i < count; i++)
    //        {
    //            var article = new Player
    //            {
    //                Name = "username #" + i,
    //                Rank = 50 + i,
    //            };
    //            scores[i] = article;
    //        }

    //        return scores;
    //    }

    //    private void SetupController(ApiController controller)
    //    {
    //        string serverUrl = "http://test-url.com";

    //        //Setup the Request object of the controller
    //        var request = new HttpRequestMessage()
    //        {
    //            RequestUri = new Uri(serverUrl)
    //        };
    //        controller.Request = request;

    //        //Setup the configuration of the controller
    //        var config = new HttpConfiguration();
    //        config.Routes.MapHttpRoute(
    //            name: "DefaultApi",
    //            routeTemplate: "api/{controller}/{action}/{id}",
    //            defaults: new { id = RouteParameter.Optional });
    //        controller.Configuration = config;

    //        //Apply the routes of the controller
    //        controller.RequestContext.RouteData =
    //            new HttpRouteData(
    //                route: new HttpRoute(),
    //                values: new HttpRouteValueDictionary
    //                {
    //                    { "controller", "games" }
    //                });
    //    }
    //}
}