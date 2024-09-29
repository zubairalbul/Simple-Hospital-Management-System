using Microsoft.VisualBasic;
using Simple_Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simple_Hospital_Management_System
{
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public string Ailment { get; set; }
        public Doctor AssignedDoctor { get; set; }
        public Room Room { get; set; }

        public Patient(int patientID, string name, int age, Gender gender, string ailment, Doctor assignedDoctor) : base(name, age, gender)
        {
            PatientID = patientID;
            Ailment = ailment;
            AssignedDoctor = assignedDoctor;
        }

        public void AssignRoom(Room room)
        {
            Room = room;
        }

        public void Discharge()
        {
            Room = null;
        }

        public override void DisplayInfo()
        {
           
            base.DisplayInfo();
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine($"Ailment: {Ailment}");
            if (Room != null)
            {
                Console.WriteLine($"Room: {Room.RoomNumber}");
            }
            Console.WriteLine($"Dr: {AssignedDoctor.Name}");
        }

    }
}




