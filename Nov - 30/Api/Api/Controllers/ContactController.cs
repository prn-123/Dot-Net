using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Api.Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SimplifiedContactManagementSystem;Integrated Security=True");
        // GET: api/Contact
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Contacts",cn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Contact> glContact = new List<Contact>();
            while(dr.Read())
            {
                Contact c = new Contact
                {
                    ContactId = Int32.Parse(dr["ContactId"].ToString()),
                    ContactName = dr["ContactName"].ToString(),
                    Location = dr["Location"].ToString()
                };
                glContact.Add(c);
            }
            cn.Close();
            return glContact;
        }

        // GET: api/Contact/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contact
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
