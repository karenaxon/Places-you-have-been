using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouHaveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesYouHaveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Obj()
    {
      Place newPlace = new Place("Seattle", "US", "35");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void PlaceCity_ReturnCityName_String()
    {
      Place newPlace = new Place("Seattle", "US", "35");
      Assert.AreEqual("Seattle", newPlace.CityName);
    }

    [TestMethod]
    public void GetAll_ReturnCityName_CityList()
    {
      string cityName = "Seattle";
      string country = "US";
      string days = "45";
      string cityName2 = "Vancouver";
      string country2 = "Canada";
      string days2 = "90";
      Place newPlace = new Place(cityName, country, days);
      Place newPlace1  = new Place(cityName2, country2, days2);
      List<Place> newList = new List<Place> {newPlace, newPlace1};
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
