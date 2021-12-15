using System.Collections.Generic;
using System;

namespace PlacesYouHaveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Country { get; set; }
    public string NumberOfDays { get; set; }

    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};
    

    public Place (string city, string country, string days)
    {
      CityName = city;
      Country = country;
      NumberOfDays = days;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}