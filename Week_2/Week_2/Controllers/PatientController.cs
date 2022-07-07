using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Week_2.DAL;
using Week_2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week_2.Controllers
{   
  
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        
        [HttpGet]
        public  List<Report> GetAllReport()
        {
            return patientDal.GetAllReports();
           
        }

        //GET api/<PatientController>/5
        [HttpGet("{id}")]
        public List<Report> GetReportsById(int id)
        {
            return patientDal.GetReportsByIdPatient( id);
        }

        //[Route("api/city/[controller]")]
        [HttpGet]
        [Route("getReportsByCity/{city}")]

        public List<Report> GetReportsByCity(string city)
        {
            return patientDal.GetReportsByCity(city);
        }

        // POST api/<PatientController>
        [HttpPost]
        [Route("{patientId}")]
        public void PostReport([FromBody] Report report, int patientId)
        {
            patientDal.AddReport(report, patientId);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{patientId, ReportId}")]
        public void Delete(int patientId, int ReportId)
        {
            
        }
    }
}
