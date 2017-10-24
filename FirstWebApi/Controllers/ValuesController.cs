using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        DBEntities db = new DBEntities();
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            return db.TblEmployees.Select(s => new Employee
            {
                Id=s.Id,
                Name = s.Name,
                City = s.City,
                Address = s.Address
            });
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            try
            {
                if (id == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Invalid data");
                }
                else
                {
                    var name = db.TblEmployees.Where(w=>w.Id == id).Select(s => new Employee
                    {
                        Id = s.Id,
                        Name = s.Name,
                        City = s.City,
                        Address = s.Address
                    });
                    return Request.CreateResponse(HttpStatusCode.OK, "Data:" + name);
                }
            }
            catch (Exception ex) { return Request.CreateResponse(HttpStatusCode.OK, "Error:" + ex.Message); }
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Employee emp)
        {
            try
            {
                if (emp == null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Invalid data");
                }
                else
                {
                    var table = new TblEmployee();
                    table.Name = emp.Name;
                    table.City = emp.City;
                    table.Address = emp.Address;
                    db.TblEmployees.Add(table);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK,"Insertion Successful");
                }
            }
            catch (Exception ex) { return Request.CreateResponse(HttpStatusCode.OK, "Error:" + ex.Message); }
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody]Employee emp)
        {
            try
            {
                if (id == null && emp == null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Invalid data");
                }
                else
                {
                    var editResult = db.TblEmployees.Where(w => w.Id == id).FirstOrDefault();
                    editResult.Name = emp.Name;
                    editResult.City = emp.City;
                    editResult.Address = emp.Address;
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Updation Successful");
                }
            }
            catch (Exception ex) { return Request.CreateResponse(HttpStatusCode.OK, "Error:" + ex.Message); }
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                if (id == null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Invalid data");
                }
                else
                {
                    var deleteResult = db.TblEmployees.Where(w => w.Id == id).FirstOrDefault();
                    db.TblEmployees.Remove(deleteResult);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK,"Updation Successful");
                }
            }
            catch (Exception ex) { return Request.CreateResponse(HttpStatusCode.OK, "Error:" + ex.Message); }
        }
    }
}
