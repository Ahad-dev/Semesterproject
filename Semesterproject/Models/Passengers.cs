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
    internal class Passengers
    {
        [BsonId]
        public int PassId { get; set; }

        [BsonElement("PassName")]
        public string? PassName { get; set; }

        [BsonElement("CNIC")]
        public string? CNIC { get; set; }

        [BsonElement("Password")]
        public string? Password { get; set; }

        [BsonElement("Role")]
        public string? Role { get; set; }

        [BsonElement("Passport")]
        public string? Passport { get; set; }

        [BsonElement("PassAddress")]
        public string? PassAddress { get; set; }

        [BsonElement("PassNationality")]
        public string? PassNationality { get; set; }

        [BsonElement("PassGender")]
        public string? PassGender { get; set; }

        [BsonElement("PassPhone")]
        public string? PassPhone { get; set; }

    }
}
