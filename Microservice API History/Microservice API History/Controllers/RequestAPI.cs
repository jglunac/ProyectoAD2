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

        [HttpGet]
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

//        var database = dbClient.GetDatabase("Resultados");
//        List<BsonDocument> Mesas = new List<BsonDocument>();
//        var collection = database.GetCollection<BsonDocument>("Resultados2023");
//        var documents = collection.Find(new BsonDocument()).ToList();
//            if (documents.Count != 0)
//            {
//                Mesa[] MesaObjeto = new Mesa[documents.Count];
//                foreach (var item in documents)
//                {
//                    Mesas.Add(item);
//                }
//                for (int k = 0;  k<Mesas.Count; k++)
//                {
//                    MesaObjeto[k] = BsonSerializer.Deserialize<Mesa>(Mesas[k]);
//                }
//string json = JsonSerializer.Serialize(MesaObjeto);
//return Ok(json);
//            }
//            else
//{
//    return NotFound();
//}
            //switch (period)
            //{
            //    case 0:
                    
            //    case 1:
            //        var collection1 = database.GetCollection<BsonDocument>("Resultados2019");
            //        var documents1 = collection1.Find(new BsonDocument()).ToList();
            //        if (documents1.Count != 0)
            //        {
            //            Mesa[] MesaObjeto = new Mesa[documents1.Count];
            //            int i = 0;
            //            foreach (var item in documents1)
            //            {
            //                MesaObjeto[i] = BsonSerializer.Deserialize<Mesa>(item);
            //                i++;
            //            }

            //            string json = JsonSerializer.Serialize(MesaObjeto);
            //            return Ok(json);
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //    case 2:
            //        var collection2 = database.GetCollection<BsonDocument>("Resultados2015");
            //        var documents2 = collection2.Find(new BsonDocument()).ToList();
            //        if (documents2.Count != 0)
            //        {
            //            Mesa[] MesaObjeto = new Mesa[documents2.Count];
            //            int i = 0;
            //            foreach (var item in documents2)
            //            {
            //                MesaObjeto[i] = BsonSerializer.Deserialize<Mesa>(item);
            //                i++;
            //            }

            //            string json = JsonSerializer.Serialize(MesaObjeto);
            //            return Ok(json);
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //    case 3:
            //        var collection3 = database.GetCollection<BsonDocument>("Resultados2011");
            //        var documents3 = collection3.Find(new BsonDocument()).ToList();
            //        if (documents3.Count != 0)
            //        {
            //            Mesa[] MesaObjeto = new Mesa[documents3.Count];
            //            int i = 0;
            //            foreach (var item in documents3)
            //            {
            //                MesaObjeto[i] = BsonSerializer.Deserialize<Mesa>(item);
            //                i++;
            //            }

            //            string json = JsonSerializer.Serialize(MesaObjeto);
            //            return Ok(json);
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //    case 4:
            //        var collection4 = database.GetCollection<BsonDocument>("Resultados2007");
            //        var documents4 = collection4.Find(new BsonDocument()).ToList();
            //        if (documents4.Count != 0)
            //        {
            //            Mesa[] MesaObjeto = new Mesa[documents4.Count];
            //            int i = 0;
            //            foreach (var item in documents4)
            //            {
            //                MesaObjeto[i] = BsonSerializer.Deserialize<Mesa>(item);
            //                i++;
            //            }

            //            string json = JsonSerializer.Serialize(MesaObjeto);
            //            return Ok(json);
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //    default:
            //        var collection5 = database.GetCollection<BsonDocument>("Resultados2023");
            //        var documents5 = collection5.Find(new BsonDocument()).ToList();
            //        if (documents5.Count != 0)
            //        {
            //            Mesa[] MesaObjeto = new Mesa[documents5.Count];
            //            int i = 0;
            //            foreach (var item in documents5)
            //            {
            //                MesaObjeto[i] = BsonSerializer.Deserialize<Mesa>(item);
            //                i++;
            //            }

            //            string json = JsonSerializer.Serialize(MesaObjeto);
            //            return Ok(json);
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //}
        //}
    }
}
