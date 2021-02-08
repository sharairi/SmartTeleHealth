using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartTeleHealth.Web.Models
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; }

        [Display(Name = "Taken At")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Updated At")]
        public DateTime UpdatedOn { get; set; }

        [Required]
        [Display(Name = "Appointment Description")]
        public String AppointmentDesc { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        public String Date { get; set; }

        [Display(Name = "Serial")]
        public int Serial { get; set; }

        [Display(Name = "UID")]
        public String Uid { get; set; }

        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Display(Name = "Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }

        public IEnumerable<SelectListItem> ScheduleDates { get; set; }
    }
}