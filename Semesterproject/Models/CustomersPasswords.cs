using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Semesterproject.Models
{
    public class CustomersPasswords
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("UserName")]
        public string? UserName { get; set; }

        [BsonElement("Password")]
        public string? Password { get; set; }

        [BsonElement("Role")]
        public string? Role { get; set; }

    }
}
