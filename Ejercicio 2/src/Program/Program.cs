using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Armand","");
            Patient patient1 = new Patient("Steven Jhonson","986782342","5555-555-555","");
            string appointmentResult = AppointmentService.SetAppointment(patient1,DateTime.Now,"Wall Street", doctor1);
            Console.WriteLine(appointmentResult);
            
            Doctor doctor2 = new Doctor("","");
            Patient patient2 = new Patient("Ralf Manson", "","5555-555-555","");
            string appointmentResult2 = AppointmentService.SetAppointment(patient2,DateTime.Now,"Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);


        }
    }
}
