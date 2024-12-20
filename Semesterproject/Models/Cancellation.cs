using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterproject.Models
{
    internal class Cancellation
    {
        [BsonId]
        public int? CancelId { get; set; }

        [BsonElement("TicketId")]
        public string? TicketId { get; set; }

        [BsonElement("Date")]
        public string? Date {  get; set; }

        [BsonElement("FlightCode")]
        public string? FlightCode { get; set; } 
    }
}
