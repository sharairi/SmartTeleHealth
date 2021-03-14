using AutoMapper;
using SmartTeleHealth.Data.Services;
using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using SmartTeleHealth.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace SmartTeleHealth.Web.Areas
{
    public class AppointmentsCalendarController : BaseController
    {
        private IDoctorService _doctorService;
        private IPatientservice _patientService;

        public AppointmentsCalendarController(ApplicationUserManager userManager,
            IDoctorService doctorService, IPatientservice patientService)
            : base(userManager)
        {
            this._doctorService = doctorService;
            this._patientService = patientService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

     

        public async Task<ContentResult> GetAppointments()
        {
            using (ApplicationDbContext dc = new ApplicationDbContext())
            {
                //var appointments = dc.Appointments.ToList();

                // Get PatientId
                var userId = await GetUserId();
                var patientId = this._patientService.GetPatientId(userId);
                var appointments = this._patientService.GetAppointmentsByPatientId(patientId);
                var model = Mapper.Map<IEnumerable<AppointmentViewModel>>(appointments);

                var list = JsonConvert.SerializeObject(model, Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });

                return Content(list, "application/json");

                //return new JsonResult { Data = model, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


            }
        }

    }
}