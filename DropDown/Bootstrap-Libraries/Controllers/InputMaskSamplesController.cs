using System;
using System.Web.Mvc;
using SamplesData;

namespace Bootstrap_Libraries.Controllers
{
  public class InputMaskSamplesController : Controller
  {
    public ActionResult Input01()
    {
      UserData model = new UserData();

      model.StartDate = null;

      return View(model);
    }

    [HttpPost]
    public ActionResult Input01(UserData model)
    {
      System.Diagnostics.Debugger.Break();

      ModelState.Clear();

      return View(model);
    }

    public ActionResult Input02()
    {
      UserData model = new UserData();

      model.StartDate = null;

      return View(model);
    }

    [HttpPost]
    public ActionResult Input02(UserData model)
    {
      System.Diagnostics.Debugger.Break();

      ModelState.Clear();

      return View(model);
    }
  }
}