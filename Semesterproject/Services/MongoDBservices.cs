using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Semesterproject.Models;

namespace Semesterproject.Services
{
    internal class MongoDBservices
    {
        private readonly IMongoCollection<Passengers> _passengersCollection;
        private readonly IMongoCollection<FlightsRecords> _flightsCollection;
        private readonly IMongoCollection<TicketsTable> _ticketsCollection;
        private readonly IMongoCollection<Cancellation> _cancelTicketCollection;
        private readonly IMongoCollection<CustomersPasswords> _passwordsCollection;

        public MongoDBservices()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("AirLineDatabase");

            // Adding Tables
            _passengersCollection = database.GetCollection<Passengers>("PassengersCollection");
            _flightsCollection = database.GetCollection<FlightsRecords>("FlightsCollection");
            _ticketsCollection = database.GetCollection<TicketsTable>("TicketsCollection");
            _cancelTicketCollection = database.GetCollection<Cancellation>("CancelTicketsCollection");
            _passwordsCollection = database.GetCollection<CustomersPasswords>("PasswordsCollection");
        }

        public IMongoCollection<Passengers> GetPassengersCollection()
        {
            return _passengersCollection;
        }

        public IMongoCollection<FlightsRecords> GetFlightsCollection()
        {
            return _flightsCollection;
        }
        public IMongoCollection<TicketsTable> GetTicketsCollection()
        {
            return _ticketsCollection;
        }

        public IMongoCollection<Cancellation> GetCancelTicketCollection()
        {
            return _cancelTicketCollection;
        }

        public IMongoCollection<CustomersPasswords> GetPasswordsCollection()
        {
            return _passwordsCollection;
        }
    }
}
