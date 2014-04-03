using reckrDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reckrDotNet.DAL
{
    public class ReckrInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReckrContext>
    {
        protected override void Seed(ReckrContext context)
        {
            var courts = new List<Court>
            {
                new Court { Name = "Campbell Park", Address = { Street = "Gilman Ave. & E. Campbell Ave.", City = "Campbell", State = "CA", ZipCode = "95008" }, Coordinates = { Latitude = "37.2870889", Longitude = "-121.9396184" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.AboveAverage, NumberOfPlayers = 4 },
                new Court { Name = "Houge Park", Address = { Street = "White Oaks Ave. & Twilight Dr.", City = "San Jose", State = "CA", ZipCode = "95124" }, Coordinates = { Latitude = "37.2563939", Longitude = "-121.9439586" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Poor, NumberOfPlayers = 18 },
                new Court { Name = "Henry Schmidt Park", Address = { Street = "555 Los Padres Blvd.", City = "Santa Clara", State = "CA", ZipCode = "95050" }, Coordinates = { Latitude = "37.336394", Longitude = "-121.960464" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Average, NumberOfPlayers = 10 },
                new Court { Name = "Fair Oaks Park", Address = { Street = "540 N Fair Oaks Ave.", City = "Sunnyvale", State = "CA", ZipCode = "94085" }, Coordinates = { Latitude = "37.3859466", Longitude = "-122.0145835" }, NumberOfCourts = 3, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.AboveAverage, NumberOfPlayers = 1 },
                new Court { Name = "24 Hour Fitness Super Sport", Address = { Street = "2535 California St.", City = "Mountain View", State = "CA", ZipCode = "94040" }, Coordinates = { Latitude = "37.4035255", Longitude = "-122.1088483" }, NumberOfCourts = 1, CourtType = "Indoor", AvgPlayerRating = PlayerRating.Average, NumberOfPlayers = 9 },
                new Court { Name = "Rucker Park", Address = { Street = "W. 155th St. & 8th Ave.", City = "Manhattan", State = "NY", ZipCode = "10039" }, Coordinates = { Latitude = "40.828884", Longitude = "-73.935615" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 14 },
                new Court { Name = "Barry Farms", Address = { Street = "1223 Sumner Rd. SE", City = "Washington", State = "DC", ZipCode = "20020" }, Coordinates = { Latitude = "38.8613044", Longitude = "-76.9971405" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating =PlayerRating.Pro, NumberOfPlayers = 7 },
                new Court { Name = "Jackson Park", Address = { Street = "6401 S. Stony Island Ave.", City = "Chicago", State = "IL", ZipCode = "60637" }, Coordinates = { Latitude = "41.7845006", Longitude = "-87.5821823" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 15 },
                new Court { Name = "Mosswood Park", Address = { Street = "3612 Webster St.", City = "Oakland", State = "CA", ZipCode = "94609" }, Coordinates = { Latitude = "37.8239325", Longitude = "-122.2603881" }, NumberOfCourts = 2, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 12 },
                new Court { Name = "Venice Beach", Address = { Street = "1700-1798 Ocean Front Walk", City = "Venice", State = "CA", ZipCode = "90291" }, Coordinates = { Latitude = "33.985824", Longitude = "-118.4727474" }, NumberOfCourts = 1, CourtType = "Outdoor", AvgPlayerRating = PlayerRating.Pro, NumberOfPlayers = 20 }
            };

            courts.ForEach(c => context.Courts.Add(c));
            context.SaveChanges();

            var players = new List<Player>
            {
                new Player { UserName = "MichaelJordan", PlayerRating = PlayerRating.Pro},
                new Player { UserName = "DominiqueWilkins", PlayerRating = PlayerRating.AboveAverage},
                new Player { UserName = "PatrickEwing", PlayerRating = PlayerRating.Average},
                new Player { UserName = "LeBronJames", PlayerRating = PlayerRating.Poor},
                new Player { UserName = "CraigEhlo", PlayerRating = PlayerRating.Pro},
                new Player { UserName = "ManuteBol", PlayerRating = PlayerRating.AboveAverage},
                new Player { UserName = "WorldBFree", PlayerRating = PlayerRating.Average},
                new Player { UserName = "LarryNance", PlayerRating = PlayerRating.Poor},
                new Player { UserName = "MarkPrice", PlayerRating = PlayerRating.Pro},
                new Player { UserName = "ScottiePippen", PlayerRating = PlayerRating.AboveAverage},
                new Player { UserName = "MagicJohnson", PlayerRating = PlayerRating.Average},
                new Player { UserName = "MosesMalone", PlayerRating = PlayerRating.Poor},
                new Player { UserName = "AllenIverson", PlayerRating = PlayerRating.Pro},
                new Player { UserName = "ArvydasSabonis", PlayerRating = PlayerRating.AboveAverage},
                new Player { UserName = "OscarRobertson", PlayerRating = PlayerRating.Average},
                new Player { UserName = "WiltChamberlain", PlayerRating = PlayerRating.Poor},
                new Player { UserName = "Shaq", PlayerRating = PlayerRating.Pro},
                new Player { UserName = "KobeBryant", PlayerRating = PlayerRating.AboveAverage},
                new Player { UserName = "LarryNance", PlayerRating = PlayerRating.Average},
                new Player { UserName = "LarryBird", PlayerRating = PlayerRating.Poor}
            };

            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();
        }
    }
}