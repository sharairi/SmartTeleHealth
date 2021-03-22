using SmartTeleHealth.Data.Services;
using SmartTeleHealth.Models;
using SmartTeleHealth.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SmartTeleHealth.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StatesController : Controller
    {
        private readonly IStateService stateService;

        public StatesController(IStateService stateService)
        {
            this.stateService = stateService;
        }
        // GET: Admin/States
        public ActionResult Index()
        {
            var states = AutoMapper.Mapper.Map<IEnumerable<StateViewModel>>(stateService.GetStates());
            return View(states);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            State state = this.stateService.GetState(id.Value);
            if (state == null)
            {
                return HttpNotFound();
            }

            var model = AutoMapper.Mapper.Map<StateViewModel>(state);
            return View(model);
        }

        // GET: Admin/States/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/States/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StateViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var state = AutoMapper.Mapper.Map<State>(model);

                    state.CreatedOn = DateTime.Now;
                    state.UpdatedOn = DateTime.Now;

                    var isSave = stateService.SaveState(state);

                    if (isSave > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch
            {
                return View(model);
            }
            return View(model);
        }

        // GET: Admin/State/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            State state = this.stateService.GetState(id.Value);
            if (state == null)
            {
                return HttpNotFound();
            }
            var model = AutoMapper.Mapper.Map<StateViewModel>(state);
            return View(model);
        }

        // POST: Admin/State/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StateViewModel model)
        {
            if (ModelState.IsValid)
            {
                State state = this.stateService.GetState(model.Id);
                state = AutoMapper.Mapper.Map(model, state);
                state.UpdatedOn = DateTime.UtcNow;


                var isUpdate = this.stateService.UpdateState(state);
                if (isUpdate > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        // GET: Admin/States/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/States/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
