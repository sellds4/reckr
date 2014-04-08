using reckrDotNet.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;

namespace reckrDotNet.Controllers
{
    public class CourtsController : ApiController
    {
        /*Court[] courts = new Court[]
        {
            new Court { CourtID = 1, Name = "Campbell Park", Address = { Street = "Gilman Ave. & E. Campbell Ave.", City = "Campbell", State = "CA", ZipCode = "95008" }, Coordinates = { Latitude = "37.2870889", Longitude = "-121.9396184" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.AboveAverage, NumberOfPlayers = 0 },
            new Court { CourtID = 2, Name = "Houge Park", Address = { Street = "White Oaks Ave. & Twilight Dr.", City = "San Jose", State = "CA", ZipCode = "95124" }, Coordinates = { Latitude = "37.2563939", Longitude = "-121.9439586" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Poor, NumberOfPlayers = 0 },
            new Court { CourtID = 3, Name = "Henry Schmidt Park", Address = { Street = "555 Los Padres Blvd.", City = "Santa Clara", State = "CA", ZipCode = "95050" }, Coordinates = { Latitude = "37.336394", Longitude = "-121.960464" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Average, NumberOfPlayers = 0 },
            new Court { CourtID = 4, Name = "Fair Oaks Park", Address = { Street = "540 N Fair Oaks Ave.", City = "Sunnyvale", State = "CA", ZipCode = "94085" }, Coordinates = { Latitude = "37.3859466", Longitude = "-122.0145835" }, NumberOfCourts = 3, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.AboveAverage, NumberOfPlayers = 0 },
            new Court { CourtID = 5, Name = "24 Hour Fitness Super Sport", Address = { Street = "2535 California St.", City = "Mountain View", State = "CA", ZipCode = "94040" }, Coordinates = { Latitude = "37.4035255", Longitude = "-122.1088483" }, NumberOfCourts = 1, CourtType = "Indoor", AvgPlayerRating = PlayerRating.Average, NumberOfPlayers = 0 },
            new Court { CourtID = 6, Name = "Rucker Park", Address = { Street = "W. 155th St. & 8th Ave.", City = "Manhattan", State = "NY", ZipCode = "10039" }, Coordinates = { Latitude = "40.828884", Longitude = "-73.935615" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 0 },
            new Court { CourtID = 7, Name = "Barry Farms", Address = { Street = "1223 Sumner Rd. SE", City = "Washington", State = "DC", ZipCode = "20020" }, Coordinates = { Latitude = "38.8613044", Longitude = "-76.9971405" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating =PlayerRating.Pro, NumberOfPlayers = 0 },
            new Court { CourtID = 8, Name = "Jackson Park", Address = { Street = "6401 S. Stony Island Ave.", City = "Chicago", State = "IL", ZipCode = "60637" }, Coordinates = { Latitude = "41.7845006", Longitude = "-87.5821823" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 0 },
            new Court { CourtID = 9, Name = "Mosswood Park", Address = { Street = "3612 Webster St.", City = "Oakland", State = "CA", ZipCode = "94609" }, Coordinates = { Latitude = "37.8239325", Longitude = "-122.2603881" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 0 },
            new Court { CourtID = 10, Name = "Venice Beach", Address = { Street = "1700-1798 Ocean Front Walk", City = "Venice", State = "CA", ZipCode = "90291" }, Coordinates = { Latitude = "33.985824", Longitude = "-118.4727474" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 0 }
        };

        public IEnumerable<Court> GetAllCourts()
        {
            return courts;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var court = courts.FirstOrDefault((c) => c.CourtID == id);
            if (court == null)
            {
                return NotFound();
            }
            return Ok(court);
        }

        public IHttpActionResult AddCourt(Court data)
        {
            // Validation?
            // Add Item to database
        }*/
    }
}
