using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using SEA_System.Models;
using System.Text.Json;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using Newtonsoft.Json.Linq;

namespace SEA_System.Controllers
{
    public class HistoryController : Controller
    {
        string Baseurl = "http://localhost:5031/";

        public async Task<ActionResult> Solicitud(IFormCollection form)
        {
            using (var client = new HttpClient())
            {
                string msg = form["id"];
                int id = Convert.ToInt32(msg);
             
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/request2023");
                if (Res.IsSuccessStatusCode)
                {
                    string Respuesta = Res.Content.ReadAsStringAsync().Result;
                    string str = JToken.Parse(Respuesta).ToString();

                    var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                    ViewBag.Mesas = MesasContadas1;
                }

                return View("MesasContadas");
            }
        }
    }
}
