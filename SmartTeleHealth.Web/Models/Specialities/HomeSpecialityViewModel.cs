using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTeleHealth.Web.Models.Specialities
{
    public class HomeSpecialityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SpecialityDoctorViewModel> Doctors { get; set; }
    }
}