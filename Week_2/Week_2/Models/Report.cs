using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_2.Models
{
    public class Report
    {
        public static int counter = 1 ;
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string location { get; set; }
        public string city { get; set; }
        public Report(){}
        public Report(DateTime startDate, DateTime endDate, string location, string city)
        {
            this.id = counter++;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.city = city;
        }
    }
}
