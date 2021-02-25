using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartTeleHealth.Models
{
    public class Appointment : SystemEntity
    {
        [Key]
        public int AppointmentId { get; set; }
        public String AppointmentDesc { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public int Serial { get; set; }
        public String Uid { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}
