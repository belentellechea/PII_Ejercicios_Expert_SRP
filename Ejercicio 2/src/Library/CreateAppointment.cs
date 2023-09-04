using System;
//using System.Text;

namespace Library
{
    public class CreateAppointment
    {
        public DateTime Date { get; set;}
        public string AppointmentPlace { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }    

        public CreateAppointment (DateTime date, string appointmentPlace, Patient patient, Doctor doctor)
        {
            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
            this.Patient = patient;
            this.Doctor = doctor;
            
        }
    }
    

    
    /*public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }
        
    }
    */
}

/*
este codigo no cumple con el SRP ya que además de crear la consulta, se validan que todos los datos sean correctos (nombre, cedula, 
numero de telefono, lugar, doctor) y luego se guarda.
*/
