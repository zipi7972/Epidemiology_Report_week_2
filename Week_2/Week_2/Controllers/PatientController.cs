using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Week_2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public  List<Report> GetAllReports()
        {
            List<Report> allReports = new List<Report>();
            foreach (Patient patient in Data.Data.patients)
            {
                allReports.AddRange(patient.reports);
            }
            return allReports;
        }

        //GET api/<PatientController>/5
        [HttpGet("{id}")]
        public List<Report> GetReportsById(int id)
        {
            foreach (Patient patient in Data.Data.patients)
            {
                if (patient.id == id)
                    return patient.reports;
            }
            return null;
        }

        //[Route("api/city/[controller]")]
        [HttpGet]
        [Route("getReportsByCity/{city}")]

        public List<Report> GetReportsByCity(string city)
        {
            List<Report> reports = new List<Report>();
            foreach (Patient patient in Data.Data.patients)
            {
                foreach (Report report in patient.reports)
                {
                    if (report.city == city)
                        reports.Add(report);
                }
            }
            return reports;
        }

        // POST api/<PatientController>
        [HttpPost]
        [Route("{patientId}")]
        public void PostReport([FromBody] Report report, int patientId)
        {
            bool patientExit = false;
            foreach (Patient patient in Data.Data.patients)
            {
                if(patient.id == patientId)
                {
                    patient.reports.Add(report);
                    patientExit = true;
                }
            }
            if (patientExit == false)
            {
                Patient newPatient = new Patient(new List<Report> { report }, patientId );
                Data.Data.patients.Add(newPatient);
            }
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
            foreach (Patient patient in Data.Data.patients)
            {
                if (patient.id == patientId)
                {
                    foreach (Report report in patient.reports)
                    {
                        if (report.id == ReportId)
                            patient.reports.Remove(report);
                    }
                }
            }
        }
    }
}
