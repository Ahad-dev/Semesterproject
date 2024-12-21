using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterproject.Models
{
    internal class Report
    {
        [BsonId]
        public string? ReportId { get; set; }

        [BsonElement]
        public string? ReportType { get; set; }

        [BsonElement]
        public string? ReportData { get; set; }

        [BsonElement]
        [BsonDateTimeOptions]
        public DateTime? ReportDate { get; set; }
    }
}
