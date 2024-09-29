using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Hospital_Management_System
{
    public class Hospital
    {
        public List<Doctor> DoctorsList { get; set; } = new List<Doctor>();
        public List<Patient> PatientsList { get; set; } = new List<Patient>();
        public List<Room> RoomsList { get; set; } = new List<Room>();

        public void AddDoctor(Doctor doctor)
        {
            DoctorsList.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            PatientsList.Add(patient);
        }

        public void AssignRoomToPatient(Patient patient, Room room)
        {
            patient.AssignRoom(room);
            room.OccupyRoom();
        }

        public void GetDoctorPatients(Doctor doctor)
        {
            Console.WriteLine($"Patients assigned to Dr. {doctor.Name}:");
            foreach (Patient patient in doctor.PatientsList)
            {
                patient.DisplayInfo();
            }
        }
    }
}
