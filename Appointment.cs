using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simple_Hospital_Management_System
{
 
        public class Appointment
        {
            public Patient Patient { get; set; }
            public Doctor Doctor { get; set; }
            public DateTime AppointmentDate { get; set; }

            public Appointment(Patient patient, Doctor doctor, DateTime appointmentDate)
            {
                Patient = patient;
                Doctor = doctor;
                AppointmentDate = appointmentDate;
            }

            public void ScheduleAppointment(DateTime date)
            {
                AppointmentDate = date;
            }

            public void CancelAppointment()
            {
                AppointmentDate = DateTime.MinValue;
            }

            public void GetAppointmentDetails()
            {
                Console.WriteLine($"Patient: {Patient.Name}");
                Console.WriteLine($"Doctor: {Doctor.Name}");
                Console.WriteLine($"Appointment Date: {AppointmentDate.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
        }

    
}
