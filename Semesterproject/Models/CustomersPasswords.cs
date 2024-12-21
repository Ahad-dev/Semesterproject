using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Semesterproject.Models
{
    public class CustomersPasswords
    {
        [BsonId]
        public string? CNIC { get; set; }

        [BsonElement("UserName")]
        public string? UserName { get; set; }

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
