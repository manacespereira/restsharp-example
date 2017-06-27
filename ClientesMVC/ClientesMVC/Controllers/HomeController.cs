using ClientesMVC.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientesMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var urlBase = "https://jsonplaceholder.typicode.com";
            var client = new RestClient(urlBase);
            var requisicao = new RestRequest($"/users", Method.GET);

            var resposta = client.Execute<List<Cliente>>(requisicao);
            var clientes = resposta.Data;

            return View(clientes);
        }
    }
}