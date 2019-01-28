using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("httpClient");
        }
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/values");
            var content = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject(content);
            return new JsonResult(values);
        }

        public IActionResult Privacy()
        {
            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
