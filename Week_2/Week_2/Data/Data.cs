using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_2.Models;

namespace Week_2.Data
{
    public class Data
    {
        public static Report report1 = new Report() { city = "jerusalem", location = "library", endDate = new DateTime(), startDate = new DateTime() };
        public static Report report2 = new Report() { city = "jerusalem", location = "restraunt", endDate = new DateTime(), startDate = new DateTime() };
        public static Report report3 = new Report() { city = "tel aviv", location = "park", endDate = new DateTime(), startDate = new DateTime() };
        public static Report report4 = new Report() { city = "bney brak", location = "garden", endDate = new DateTime(), startDate = new DateTime() };
        public static Report report5 = new Report() { city = "bney brak", location = "school", endDate = new DateTime(), startDate = new DateTime() };

        public static List<Patient> patients = new List<Patient>()
        {
            { new Patient(new List<Report> { report1, report2, report3 }, 1)},
            { new Patient(new List<Report> { report1, report5 }, 2)},
            { new Patient(new List<Report> { report2, report4, report5 }, 3)},
            { new Patient(new List<Report> { report1, report2, report3, report4 }, 4)},

        };
    }
}
