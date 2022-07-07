using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_2.Models;

namespace Week_2.DAL
{
    public class patientDal
    {

        //A function that return all reports.
        public static List<Report> GetAllReports()
        {

            List<Report> allReports = new List<Report>();
            foreach (Patient patient in Data.Data.patients)
            {
                allReports.AddRange(patient.reports);
            }
            return allReports;
        }


        //A function that get idPatient and return all his reports.
        public static List<Report> GetReportsByIdPatient(int id)
        {
            foreach (Patient patient in Data.Data.patients)
            {
                if (patient.id == id)
                    return patient.reports;
            }
            return null;
        }

        // A function tat get city and return all reports un thus city.
        public static List<Report> GetReportsByCity(string city)
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


        // A function that get report of one patient and add it to this patient reports.
        public static void AddReport(Report report, int patientId)
        {
            bool patientExit = false;
            foreach (Patient patient in Data.Data.patients)
            {
                if (patient.id == patientId)
                {
                    patient.reports.Add(report);
                    patientExit = true;
                }
            }
            if (patientExit == false)
            {
                Patient newPatient = new Patient(new List<Report> { report }, patientId);
                Data.Data.patients.Add(newPatient);
            }
        }

    }
}
