using ERP.Domain;
using ERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ERP.Controllers {
    public class HomeController : ApiController {
        // GET api/<controller>
        public IEnumerable<string> Get() {
            var dbContext = new ERPMashinesDbContext();

            using (dbContext) {
                dbContext.Facilities.Add(new Facility() {Id = 1, DueDate = new DateTime(2017,1,1), IdFacilityGroup = 1, Location = "NP"  });
                dbContext.Indexes.Add(new Index() { Id = 1, dataType = typeof(int), Description = "This", IdFacility = 1 });

                dbContext.SaveChanges();
            }

            return dbContext.Indexes.Where(x => x.Id == 1).Select(x => x.Description);
        }

        // GET api/<controller>/5
        public string Get(int id) {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value) {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
        }
    }
}