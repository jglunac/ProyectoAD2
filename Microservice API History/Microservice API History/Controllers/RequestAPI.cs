using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json;
using SEA_System.Models;

namespace Microservice_API_History.Controllers
{

    [ApiController]
    [Route("api")]
    public class RequestAPI : Controller
    {
        const string connectionUri = "mongodb+srv://Admin:admin123@seahistory.onjfrar.mongodb.net/?retryWrites=true&w=majority";

        [Route("request2023")]
        public IActionResult History2023(int period)
        {
            MongoClient dbClient = new MongoClient(connectionUri);

            var database = dbClient.GetDatabase("Resultados");
            var collection = database.GetCollection<BsonDocument>("Resultados2023");
            var document = collection.Find(new BsonDocument()).ToList();
            var ListaMesas = new List<Mesa>();
            if (document.Count != 0)
            {
                foreach (var item in document)
                {
                    ListaMesas.Add(BsonSerializer.Deserialize<Mesa>(item));
                }
                Mesas mesas = new Mesas();
                mesas.mesas = ListaMesas;
                mesas.count = ListaMesas.Count;
                string json = JsonSerializer.Serialize(mesas);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("request2019")]

        public IActionResult History2019(int period)
        {
            MongoClient dbClient = new MongoClient(connectionUri);

            var database = dbClient.GetDatabase("Resultados");
            var collection = database.GetCollection<BsonDocument>("Resultados 2019");
            var document = collection.Find(new BsonDocument()).ToList();
            var ListaMesas = new List<Mesa>();
            if (document.Count != 0)
            {
                foreach (var item in document)
                {
                    ListaMesas.Add(BsonSerializer.Deserialize<Mesa>(item));
                }
                Mesas mesas = new Mesas();
                mesas.mesas = ListaMesas;
                mesas.count = ListaMesas.Count;
                string json = JsonSerializer.Serialize(mesas);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("request2015")]

        public IActionResult History2015(int period)
        {
            MongoClient dbClient = new MongoClient(connectionUri);

            var database = dbClient.GetDatabase("Resultados");
            var collection = database.GetCollection<BsonDocument>("Resultados2015");
            var document = collection.Find(new BsonDocument()).ToList();
            var ListaMesas = new List<Mesa>();
            if (document.Count != 0)
            {
                foreach (var item in document)
                {
                    ListaMesas.Add(BsonSerializer.Deserialize<Mesa>(item));
                }
                Mesas mesas = new Mesas();
                mesas.mesas = ListaMesas;
                mesas.count = ListaMesas.Count;
                string json = JsonSerializer.Serialize(mesas);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("request2011")]

        public IActionResult History2011(int period)
        {
            MongoClient dbClient = new MongoClient(connectionUri);

            var database = dbClient.GetDatabase("Resultados");
            var collection = database.GetCollection<BsonDocument>("Resultados2011");
            var document = collection.Find(new BsonDocument()).ToList();
            var ListaMesas = new List<Mesa>();
            if (document.Count != 0)
            {
                foreach (var item in document)
                {
                    ListaMesas.Add(BsonSerializer.Deserialize<Mesa>(item));
                }
                Mesas mesas = new Mesas();
                mesas.mesas = ListaMesas;
                mesas.count = ListaMesas.Count;
                string json = JsonSerializer.Serialize(mesas);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("request2007")]

        public IActionResult History2007(int period)
        {
            MongoClient dbClient = new MongoClient(connectionUri);

            var database = dbClient.GetDatabase("Resultados");
            var collection = database.GetCollection<BsonDocument>("Resultados2007");
            var document = collection.Find(new BsonDocument()).ToList();
            var ListaMesas = new List<Mesa>();
            if (document.Count != 0)
            {
                foreach (var item in document)
                {
                    ListaMesas.Add(BsonSerializer.Deserialize<Mesa>(item));
                }
                Mesas mesas = new Mesas();
                mesas.mesas = ListaMesas;
                mesas.count = ListaMesas.Count;
                string json = JsonSerializer.Serialize(mesas);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
