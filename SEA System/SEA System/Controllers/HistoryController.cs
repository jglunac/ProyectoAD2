using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using SEA_System.Models;
using System.Text.Json;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

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
                switch (id)
                {
                    case 0:
                        HttpResponseMessage Res = await client.GetAsync("api/request2023");
                        if (Res.IsSuccessStatusCode)
                        {
                            string Respuesta = Res.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                    case 1:
                        HttpResponseMessage Res1 = await client.GetAsync("api/request2019");
                        if (Res1.IsSuccessStatusCode)
                        {
                            string Respuesta = Res1.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                    case 2:
                        HttpResponseMessage Res2 = await client.GetAsync("api/request2015");
                        if (Res2.IsSuccessStatusCode)
                        {
                            string Respuesta = Res2.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                    case 3:
                        HttpResponseMessage Res3 = await client.GetAsync("api/request2011");
                        if (Res3.IsSuccessStatusCode)
                        {
                            string Respuesta = Res3.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                    case 4:
                        HttpResponseMessage Res4 = await client.GetAsync("api/request2007");
                        if (Res4.IsSuccessStatusCode)
                        {
                            string Respuesta = Res4.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                    case 5:
                        HttpResponseMessage Res5 = await client.GetAsync("api/request2023");
                        if (Res5.IsSuccessStatusCode)
                        {
                            string Respuesta = Res5.Content.ReadAsStringAsync().Result;
                            string str = JToken.Parse(Respuesta).ToString();

                            var MesasContadas1 = JsonSerializer.Deserialize<Mesas>(str);
                            ViewBag.selected = MesasContadas1;
                        }
                        break;
                }
                

                return View("MesasContadas");
            }
        }
    }
}
