using _2ndClass.Data;
using _2ndClass.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2ndClass.Controllers
{
    [Route("api/[controller]")]  //www.localhost.com/api/Departments --> fiddler, postman
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private MyDbContext context;
        public DepartmentsController(MyDbContext _context)
        {
            context = _context;
        }
        //HTTP Methods, HTTP Status

        //GetAll
        [HttpGet("getAll")]
        public ActionResult<IEnumerable<Departments>> GetAll()
        {
            var list = context.Departments.ToList();
            return Ok(new JsonResponse() { IsSuccess = true, Data = list });

        }
        //GetById
        [HttpGet("getById")]
        public ActionResult<Departments> GetById(int id)
        {
            var obj = context.Departments.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        //Insert
        [HttpPost]
        public ActionResult Insert(Departments model)
        {
            context.Departments.Add(model);
            context.SaveChanges();
            return Ok(model);
        }
        //Update
        [HttpPut]
        public ActionResult Update(Departments model)
        {
            try
            {
                    context.Departments.Update(model);
                    context.SaveChanges();
                    return Ok(model);
            }
            catch (Exception ex)
            {
               throw;
            }
        }
        //Delete
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var obj = context.Departments.Find(id);
                if (obj == null)
                {
                    return NotFound("Record not found.");
                }
                else
                {
                    context.Departments.Remove(obj);
                    context.SaveChanges();
                    return NoContent();
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
