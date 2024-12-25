using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Semesterproject.Models
{
    internal class TicketsTable
    {
        [BsonId]
        public string? TicketId { get; set; }

        [BsonElement("FlCode")]
        public string? FlCode { get; set; }

        [BsonElement("PassId")]
        public string? PassId { get; set; }

        [BsonElement("PassNation")]
        public string? PassNation { get; set; }

        [BsonElement("Amount")]
        public int? Amount { get; set; }

        [BsonElement("Phone")]
        public string? Phone { get; set; }

        [BsonElement("Passname")]
        public string? Passname { get; set; }

        [BsonElement("Passport")]
        public string? Passport { get; set; }

    }
}
