using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterproject.Models
{
    internal class FeedbackModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("userId")]
        public string? UserId { get; set; }

        [BsonElement("userName")]
        public string? UserName { get; set; }

        [BsonElement("cnic")]
        public string? CNIC { get; set; }

        [BsonElement("rating")]
        public string? Rating { get; set; }

        [BsonElement("FlightID")]
        public string? FlightID { get; set; }

        [BsonElement("comment")]
        public string? Comment { get; set; }

        [BsonElement("createdAt")]
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
