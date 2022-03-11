using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class JsonResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }  //List<Department>, List<Employees>, Category, Product
        public int ErrorCode { get; set; }
        public List<string> Errors { get; set; }
    }
}
