using Microsoft.AspNetCore.Mvc;
using PlacesYouBeen.Models;
using System.Collections.Generic;

namespace PlacesYouBeen.Controllers
{
  public class PlacesController : Controller
  {
  [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
