using System;
using System.Linq;
using Jokes.App_Start;
using Jokes.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jokes.Tests.Fakes;
using System.Web.Mvc;
using System.Collections.Generic;
using Jokes.Data;
using Jokes.Services;

namespace Jokes.Tests.Controllers
{
  [TestClass]
  public class HomeControllerTests
  {
    private FakeJokesRepository _repo;
    private HomeController _ctrl;

    [TestInitialize]
    public void Init()
    {
      _repo = new FakeJokesRepository();
      _ctrl = new HomeController(new MockMailService(), _repo);

    }

    [TestMethod]
    public void IndexCanRender()
    {
      var result = _ctrl.Index();
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void IndexHasData()
    {
      var result = _ctrl.Index() as ViewResult;
      var topics = result.Model as IEnumerable<Topic>;

      Assert.IsNotNull(result.Model);
      Assert.IsNotNull(topics);
      Assert.IsTrue(topics.Count() > 0);

    }
  }
}
