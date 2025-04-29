using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Semesterproject.Models
{
    public class FlightsRecords
    {
        [BsonId]
        public int FlightCode { get; set; }

        [BsonElement("Source")]
        public string? Source { get; set; }

        [BsonElement("Destination")]
        public string? Destination { get; set; }

        [BsonElement("TotalSeats")]
        public int? TotalSeats { get; set; }

        [BsonElement("TakeofDate")]
        public string? TakeofDate { get; set; }

        [BsonElement("PilotID")]
        public string? PilotID { get; set; }
    }
}
