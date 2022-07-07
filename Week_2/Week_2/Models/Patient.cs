using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_2.Models
{
    public class Patient
    {
        public List<Report> reports { get; set; }
        public int id { get; set; }
        public Patient(){}
        public Patient(List<Report> reports, int id)
        {
            this.reports = new List<Report>();
            this.reports = reports;
            this.id = id;
        }
    }
}
