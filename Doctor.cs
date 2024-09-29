using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Hospital_Management_System
{
    public class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string Specialization { get; set; }
        public List<Patient> PatientsList { get; set; } = new List<Patient>();

        public Doctor(int doctorID, string name, int age, Gender gender, string specialization) : base(name, age, gender)
        {
            DoctorID = doctorID;
            Specialization = specialization;
        }

        public void AddPatient(Patient patient)
        {
            PatientsList.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            PatientsList.Remove(patient);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doctor ID: {DoctorID}");
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}