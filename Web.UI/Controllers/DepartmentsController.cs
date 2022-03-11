using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class DepartmentsController : Controller
    {
        string baseApiURL = "http://localhost:50097/api";
        public async Task<IActionResult> Index()
        {
            var list = await GetDepartments();
             return View(list);
        }

        public async Task<List<Department>> GetDepartments()
        {
            List<Department> list = new List<Department>();
            string endPoint = $"{baseApiURL}/Departments/getAll";
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(endPoint))
                {
                    string resultStr = response.Content.ReadAsStringAsync().Result.ToString();

                    var result = JsonConvert.DeserializeObject<JsonResponse>(resultStr); //Deserialize Result

                    if (result.IsSuccess)
                    {
                        list = JsonConvert.DeserializeObject<List<Department>>(result.Data.ToString());
                    }
                }
            }

            return list;
        }
    }
}
